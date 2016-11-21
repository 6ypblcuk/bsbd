<?php
define("DB_SERVER", "localhost"); 
define("DB_USERNAME", "root"); 
define("DB_PASSWORD", "");
define("DB_DATABASE", "drugstore"); 
$connection = mysql_connect(DB_SERVER, DB_USERNAME, DB_PASSWORD) or die(mysql_error());
$database = mysql_select_db(DB_DATABASE) or die(mysql_error());
define("DB_CHARSET", "utf8");

function searchdrug($type, $data,$firms) {
    print json_encode(array(
        'type' => array($type),
        'data' =>  array($data),
		'firm_name' => $firms));
    exit();
}
function pricecount($type, $data) {
    print json_encode(array(
        'type' => array($type),
        'data' =>  array($data)));
    exit();
}
function make_error($type) {
    print json_encode(array(
        'type' => array($type)));
    exit();
}
function make_card($type,$data) {
    print json_encode(array(
        'type' => array($type),
		'data'=> array(array('card' => $data))));
    exit();
}
$action = $_GET['action'];

if ($action == "search_drug")
{
	$name_drug = $_GET['name_drug'];
	$sql_drug= "select id_drug,name_drug,pharm_group,exp_date,form from drugs where name_drug ='$name_drug'";
	$result = mysql_query($sql_drug);
	$counts = mysql_num_rows($result);
	if ($counts != 0)
	{
		$type_error = (array(  'error'=> "success"));
		$match_value = mysql_fetch_array($result);
		$id_d = $match_value['id_drug'];
		$sql_firm = "select name_firm from firm inner join (select id_firm from prices where id_drug = '$id_d') as t1 using(id_firm)";
		$result1 = mysql_query($sql_firm);
		while($row = mysql_fetch_assoc($result1)){
			$json[] = $row;
		}
		$match_value1 = mysql_fetch_array($result1);
		searchdrug($type_error,$match_value,$json);
	}
	else
	{
		$type_error = (array(  'error'=> "error"));
		searchdrug($type_error,'kuku','kuku');
	}
}

if ($action =="price_count" )
{
	$name_firm = $_GET['name_firm'];
	$counts = $_GET['counts'];
	$id_drug = $_GET['id_drug'];
	$sql_price = "select price*'$counts' countspr from prices where id_drug = '$id_drug' and id_firm = (select id_firm from firm where name_firm='$name_firm')";
	$result_price = mysql_query($sql_price);
	$sql_count = "select counts from prices where id_drug='$id_drug' and id_firm = (select id_firm from firm where name_firm='$name_firm')";
	$result_count = mysql_query($sql_count);
	$match_value2 = mysql_fetch_array($result_count);
	$count_drug = $match_value2['counts'];
	if ($count_drug < $counts  )
	{
		$type_error = (array(  'error'=> "much"));
		make_error($type_error);
	}
	else
	{
		$type_error = (array(  'error'=> "success"));
		$match_value3 = mysql_fetch_array($result_price);
		$match = array('prcounts' => $match_value3['countspr']);
		pricecount($type_error,$match);
	}	
}
if ($action == "card")
{
	$id_u = $_GET['id_user'];
	$sql_card = "select default_card from users_info where id_user = '$id_u'";
	$result_card = mysql_query($sql_card);
	$counts = mysql_num_rows($result_card);
	if ($counts != 0)
	{
		$match=mysql_fetch_array($result_card);
		$card=$match['default_card'];
		$str=substr_replace($card,"****-****-****-",0,strlen($card)-4);
		$type_error = (array(  'error'=> "success"));
		make_card($type_error,$str);
	}
	else
	{
		$type_error = (array(  'error'=> "error"));
		make_error($type_error);
	}
}

function idorder($type, $data) {
    print json_encode(array(
        'type' => array($type),
        'data' =>  array($data)));
    exit();
}


 
?> 