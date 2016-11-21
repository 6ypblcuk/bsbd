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
    exit();// обязательно завершаем выполнение всех дальнейших действий сервера.
}
$action=$_GET['action'];
if ($action=="order_drug")
{
	$id_user = $_GET['id_user']; 
	if ($id_user == 0)
	{
		$sql_empl = "select fullname, id_order, date_order, summ,status from orders inner join users using (id_user) ";
		$result_empl  = mysql_query($sql_empl);
		while($row = mysql_fetch_assoc($result_empl)){
			$json[] = $row;
		}
		$result = (array(  'error'=> "success"));
		make_answer($result, $json);
	}
	else
	{
		$sql_user = "select * from orders where id_user='$id_user'";
		$result_user = mysql_query($sql_user);
		$counts=mysql_num_rows($result_user);
		if ($counts>0)
		{
			while($row = mysql_fetch_assoc($result_user)){
				$json[] = $row;
			}
			$result = (array(  'error'=> "success"));
			make_answer($result, $json);
		}
		else
		{
			$result = (array(  'error'=> "null"));
			make_answer($result, "kuku");
		}
	}
}

 
?> 