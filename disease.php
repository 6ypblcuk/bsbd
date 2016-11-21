<?php
define("DB_SERVER", "localhost"); 
define("DB_USERNAME", "root"); 
define("DB_PASSWORD", "");
define("DB_DATABASE", "drugstore"); 
$connection = mysql_connect(DB_SERVER, DB_USERNAME, DB_PASSWORD) or die(mysql_error());
$database = mysql_select_db(DB_DATABASE) or die(mysql_error());
define("DB_CHARSET", "utf8");
define("ANSWER_SUCCESS", "success");
define("ANSWER_ERROR", "error");
function make_answer($type, $match) {
    print json_encode(array(
        'type' => array($type),
        'data' =>  $match));
    exit();
}
$action = $_GET['action'];
if ($action =="select")
{
	$sql_empl = "select name_dis,id_dis,drug from disease order by name_dis";
		$result_empl  = mysql_query($sql_empl);
		while($row = mysql_fetch_assoc($result_empl)){
			$json[] = $row;
		}
		$result = (array(  'error'=> "success"));
		make_answer($result, $json);
}
function make_error($type) {
    print json_encode(array(
        'type' => array($type)));
    exit();
}
if ($action == "delete_disease")
{
	$id_dis = $_GET['id_dis'];
	$sql_dis = "delete from disease where id_dis = '$id_dis'";
	$result = mysql_query($sql_dis);
	$resulterr = (array(  'error'=> "success"));
	make_error($resulterr);
}

 
?> 
