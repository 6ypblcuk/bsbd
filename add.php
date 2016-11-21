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
function make_answer($type) {
    print json_encode(array(
        'type' => array($type)));
    exit();
}
$action = $_GET['action'];
if ($action =="price")
{
	$name_drug = $_GET['name_drug'];
	$name_firm = $_GET['name_firm'];
	$counts= $_GET['counts'];
	$price = $_GET['price'];
	$sql = mysql_query("select id_drug from drugs where name_drug='$name_drug'");
	$count = mysql_num_rows($sql);
	if ($count != 0)
	{
		$match_value = mysql_fetch_array($sql);
		$id_drug = $match_value['id_drug'];
		$sql1 = mysql_query("select id_firm from firm where name_firm='$name_firm'");
		$count1 = mysql_num_rows($sql1);
		if ($count1 != 0)
		{
			$match_value1 = mysql_fetch_array($sql1);
			$id_firm = $match_value1['id_firm'];
			$sql2 = mysql_query("select * from prices where id_firm='$id_firm' and id_drug='$id_drug'");
			$count2 = mysql_num_rows($sql2);
			if ($count2==0)
			{
				$sql_price = mysql_query("insert into prices (id_drug,id_firm,counts,price) values ('$id_drug','$id_firm', '$counts','$price')");
				$result = (array(  'error'=> "success"));
				make_answer($result);
			}
			else
			{
				$result = (array(  'error'=> "error"));
				make_answer($result);
			}
		}
		else
		{
			//Фирмы не существует
			$result = (array(  'error'=> "nope_firm"));
			make_answer($result);
		}
	}
	else
	{
		//Препарата не существует
		$result = (array(  'error'=> "nope_drug"));
		make_answer($result);
	}
}
if ($action == "disease")
{
	$name_disease = $_GET['name_disease']; 
	$drugs = $_GET['drugs'];
	$id_dis=$_GET['id_dis'];
	$sql="SELECT * FROM disease WHERE name_dis='$name_disease'";  
	$result=mysql_query($sql); 
	$counts=mysql_num_rows($result);
	if($counts==0){
		$document_get = mysql_query("insert into disease (id_dis,name_dis,drug_type) values ('$id_dis','$name_disease','$drugs')");
		$result = (array(  'error'=> "success"));
		make_answer($result);
	}
	else {
		$result = (array(  'error'=> "error"));
		make_answer($result);
	};
}
if ($action == "firm")
{
	$name = $_GET['name']; 
	$site = $_GET['site'];
	$address = $_GET['address'];
	$phone = $_GET['phone'];
	$bank = $_GET['bank'];
	$check = $_GET['check'];
	$sql="SELECT * FROM firm WHERE name_firm='$name' or phone='$phone' or check_acc='$check'";  
	$result=mysql_query($sql);
	$counts=mysql_num_rows($result);
	if($counts==0){
		$document_get = mysql_query("insert into firm(name_firm, address, phone, bank, check_acc, site) values ('$name','$address', '$phone', '$bank', '$check', '$site');");
		$result = (array(  'error'=> "success"));
		make_answer($result);
	}
	else {
		$result = (array(  'error'=> "error"));
		make_answer($result);
	};
}
if ($action == "pills")
{
	$drug_name = $_GET['drug_name']; 
	$active_sub = $_GET['active_sub']; 
	$chem_name = $_GET['chem_name'];
	$pharmgr = $_GET['pharmgr'];
	$pharmoc = $_GET['pharmoc'];
	$subuse = $_GET['subuse'];
	$contr = $_GET['contr'];
	$seff = $_GET['seff'];
	$overdose = $_GET['overdose'];
	$inter = $_GET['inter'];
	$dose = $_GET['dose'];
	$expdate = $_GET['expdate'];
	$comp = $_GET['comp'];
	$form = $_GET['form'];

	$sql="SELECT * FROM drugs WHERE name_drug='$drug_name'";  
	$result=mysql_query($sql); 
	$counts=mysql_num_rows($result);
	if($counts==0){
		$document_get = mysql_query("insert into drugs(name_drug,active_sub,chem_name,pharm_group,pharmac,sub_use,contrain,side_eff,overdose,inter,dose,exp_date,composition,form) values ('$drug_name','$active_sub','$chem_name','$pharmgr','$pharmoc','$subuse','$contr','$seff','$overdose','$inter','$dose','$expdate','$comp','$form')");
		$result = (array(  'error'=> "success"));
		make_answer($result);
	}
	else {
		$result = (array(  'error'=> "error"));
		make_answer($result);
	};
}

 
?> 