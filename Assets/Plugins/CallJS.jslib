mergeInto(LibraryManager.library, {

  AddButton:function(){
    var parent = document.getElementById("bannerPoint");
    parent.innerHTML =
                  "<ul class=\"list-unstyled list-inline\" style=\"margin-left: 50px\">" +
                  "<li><img id=\"point1\" class=\"img-circle\" style=\"background-color: #CCCCCC;width: 15px;height: 15px;\"" +
                  "onclick=\"setBannerImage(1)\" src=\"Images/point_active.png\"></li>" +
                  "<li><img id=\"point2\" class=\"img-circle\" style=\"background-color: #CCCCCC;width: 15px;height: 15px;\"" +
                  "onclick=\"setBannerImage(2)\" src=\"Images/point_default.png\"></li>" +
                  "<li><img id=\"point3\" class=\"img-circle\" style=\"background-color: #CCCCCC;width: 15px;height: 15px;\"" +
                  "onclick=\"setBannerImage(3)\" src=\"Images/point_default.png\"></li>" +
                  "</ul>";
  }
});