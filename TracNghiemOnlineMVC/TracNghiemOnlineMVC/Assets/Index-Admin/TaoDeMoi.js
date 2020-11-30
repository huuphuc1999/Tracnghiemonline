$(function(){
	$('#btn-Menu').on('click',function(){
		$('#left,#right,#Main').toggleClass('hide');
	});	
});

$(function(){
	$('#btn-BT').on('click',function(){
		$('#btn-Bat,#btn-Tat').toggleClass('on-off');
	});	
});