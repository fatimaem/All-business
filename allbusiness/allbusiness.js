$(window).scroll(function () {
    var sticky = $('.sticky'),
      scroll = $(window).scrollTop();

    if (scroll >= 15) sticky.addClass('fixed');
    else sticky.removeClass('fixed');
  });
$('.categories').click(function(){
$('.content').hide();
$('.category').show(300)
})
$('.branding').click(function(){
$('.content').hide();
$('.brand').show(300)
})
$('.business').click(function(){
$('.content').hide();
$('.busy').show(300)
})
$('.design').click(function(){
$('.content').hide();
$('.color').show(300)
})
$('.material').click(function(){
$('.content').hide();
$('.materials').show(300)
})

$(document).ready(function() {
  $('#media').carousel({
    pause: false,
    interval: 3000,
  });
});

$('.sub2').mouseover(function(){
  $(this).find('.carousel2').show()                           
})
$('.sub2').mouseout(function(){
    $(this).find('.carousel2').hide()
})
  
 