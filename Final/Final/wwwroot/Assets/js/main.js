$(document).ready(function() {
    $('.item').slick({
        arrows: true
    });
    $('.portfolio-item').isotope({
        itemSelector: '.Latest-post-list-wrap',
        layoutMode: 'fitRows'
    })
    $('.nav-tabs .nav-item').click(function() {
        $('.nxp-tab-inner ul li').removeClass('active')
        $(this).addClass('active')
        var selector = $(this).attr('data-filter');
        $('.portfolio-item').isotope({
            filter: selector
        })
        return false;
    })
    $(".modal-on").click(function(){
        $(".modal-container").css("display","block")
    });
    $(".close-icon").click(function(){
        $(".modal-container").css("display","none")
    })

    $('.nav-inner .nav-item').click(function(e) {
        e.preventDefault();
        let dataFilter = this.dataset.filter;
        console.log(dataFilter);
        let tabPane = document.querySelectorAll("#Trending .tab-pane");
        for (let i = 0; i < tabPane.length; i++) {
            tabPane[i].classList.remove("active");
            tabPane[i].classList.remove("show");
            tabPane[i].style["left"] = "636px";
        }

        for (let i = 0; i < tabPane.length; i++) {
            if (tabPane[i].dataset.filter == dataFilter) {
                tabPane[i].classList.add("active");
                tabPane[i].classList.add("show");
                tabPane[i].style["left"] = "0px";
            }
        }


        $('.nav-inner .nav-item').removeClass('active')
        $(this).addClass('active')


        return false;
    })
    $('.nav-trend .nav-item').click(function(e) {
        e.preventDefault();
        let dataFilter = this.dataset.filter;
        console.log(dataFilter);
        let tabPane2 = document.querySelectorAll("#Cloud .tab-pane");
        for (let i = 0; i < tabPane2.length; i++) {
            tabPane2[i].classList.remove("active");
            tabPane2[i].classList.remove("show");
            tabPane2[i].style["left"] = "636px";
        }
        for (let i = 0; i < tabPane2.length; i++) {
            if (tabPane2[i].dataset.filter == dataFilter) {
                tabPane2[i].classList.add("active");
                tabPane2[i].classList.add("show");
                tabPane2[i].style["left"] = "0px";
            }
        }

        $('.nav-trend .nav-item').removeClass('active')
        $(this).addClass('active')


        return false;
    })
    $(window).scroll(function() {

        if ($("html").scrollTop() >= 400) {
            $('.navbar').addClass('slide')
            $('.navbar').addClass('animate__animated')
            $('.navbar').addClass('animate__fadeInDown')


        } else {
            $('.navbar').removeClass('slide')
            $('.navbar').removeClass('animate__animated')
            $('.navbar').removeClass('animate__fadeInDown')
        }

    });
})