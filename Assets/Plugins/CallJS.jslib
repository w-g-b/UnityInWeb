mergeInto(LibraryManager.library, {

  AddButton:function(){
      var parent = document.getElementById("bannerButton");
      var btn1 = document.createElement("button");
      btn1.setAttribute("class", "btn btn-default");
      btn1.setAttribute("onClick", "setBannerImage(1)");
      btn1.innerHTML = "o";
      var btn2 = document.createElement("button");
      btn2.setAttribute("class", "btn btn-default");
      btn2.setAttribute("onClick", "setBannerImage(2)");
      btn2.innerHTML = "o";
      var btn3 = document.createElement("button");
      btn3.setAttribute("class", "btn btn-default");
      btn3.setAttribute("onClick", "setBannerImage(3)");
      btn3.innerHTML = "o";
      parent.appendChild(btn1);
      parent.appendChild(btn2);
      parent.appendChild(btn3);
  }
});