<%@ Page Title="" Language="C#" MasterPageFile="~/KapdeWala.master" AutoEventWireup="true" CodeFile="IndexPage.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/home.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="container-fluid" style="">
    <div class="row" style="margin-top:100px; ">
     <div class="col-sm-12" style=" padding:0px">
       <div class="container-fuild" style=" margin:0px; padding:0px;">
  <div id="myCarousel" class="carousel slide" data-ride="carousel">
    <!-- Indicators -->
    <ol class="carousel-indicators">
      <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
      <li data-target="#myCarousel" data-slide-to="1"></li>
      <li data-target="#myCarousel" data-slide-to="2"></li>
      <li data-target="#myCarousel" data-slide-to="3"></li>
      <li data-target="#myCarousel" data-slide-to="4"></li>
      <li data-target="#myCarousel" data-slide-to="5"></li>
      <li data-target="#myCarousel" data-slide-to="6"></li>
      <li data-target="#myCarousel" data-slide-to="7"></li>
    </ol>

    <!-- Wrapper for slides -->
    <div class="carousel-inner">

      <div class="item active">
       <img src="images/clothes/a.jpg" alt="Chicago" style="width:100%; height:450px">
        <div class="carousel-caption">
          <h3>Los Angeles</h3>
          <p>LA is always so much fun!</p>
        </div>
      </div>

     <div class="item" >
       <img src="images/clothes/b.jpg" alt="Chicago" style="width:100%; height:450px">
        <div class="carousel-caption">
          <h3>Los Angeles</h3>
          <p>LA is always so much fun!</p>
        </div>
      </div>
          
      <div class="item" >
       <img src="images/clothes/c.jpg" alt="Chicago" style="width:100%; height:450px">
        <div class="carousel-caption">
          <h3>Los Angeles</h3>
          <p>LA is always so much fun!</p>
        </div>
      </div>

      <div class="item" >
       <img src="images/clothes/d.jpg" alt="Chicago" style="width:100%; height:450px">
        <div class="carousel-caption">
          <h3>Los Angeles</h3>
          <p>LA is always so much fun!</p>
        </div>
      </div>

      <div class="item" >
       <img src="images/clothes/e.jpg" alt="Chicago" style="width:100%; height:450px">
        <div class="carousel-caption">
          <h3>Los Angeles</h3>
          <p>LA is always so much fun!</p>
        </div>
      </div>

      <div class="item" >
       <img src="images/clothes/f.jpg" alt="Chicago" style="width:100%; height:450px">
        <div class="carousel-caption">
          <h3>Los Angeles</h3>
          <p>LA is always so much fun!</p>
        </div>
      </div>

      <div class="item" >
       <img src="images/clothes/g.jpg" alt="Chicago" style="width:100%; height:450px">
        <div class="carousel-caption">
          <h3>Los Angeles</h3>
          <p>LA is always so much fun!</p>
        </div>
      </div>

      <div class="item" >
       <img src="images/clothes/h.jpg" alt="Chicago" style="width:100%; height:450px">
        <div class="carousel-caption">
          <h3>Los Angeles</h3>
          <p>LA is always so much fun!</p>
        </div>
      </div>
    
    </div   >

    <!-- Left and right controls -->
    <a class="left carousel-control" href="#myCarousel" data-slide="prev">
      <span class="glyphicon glyphicon-chevron-left"></span>
      <span class="sr-only">Previous</span>
    </a>
    <a class="right carousel-control" href="#myCarousel" data-slide="next">
      <span class="glyphicon glyphicon-chevron-right"></span>
      <span class="sr-only">Next</span>
    </a>
  </div>
</div>

     
     </div>
    </div>
   <!--End Slider-->
   <!--meddle div-->

      <div class="row" style=" margin-top:30px;" >
   <h2 style="color:Gray">Fashion Best Seller</h2>
    <div class="col-sm-12">
        
        <div class="recommended_items"><!--recommended_items-->
						
						
						<div id="recommended-item-carousel" class="carousel slide" data-ride="carousel">
							<div class="carousel-inner">
								<div class="item active">	
									<div class="col-sm-3">
										<div class="product-image-wrapper">
											<div class="single-products">
												<div class="productinfo text-center">
													<img src="Product_Image/i.jpeg" width="150" height"300" />
													<h2>&#8377;881</h2>
													<p>Levis Solid Men Round Neck Black,<br /> White T-Shirt</p>
													
												</div>
												
											</div>
										</div>
									</div>
									<div class="col-sm-3">
										<div class="product-image-wrapper">
											<div class="single-products">
												<div class="productinfo text-center">
													<img src="Product_Image/e.jpeg" width="150" height"300" />
													<h2>&#8377;844</h2>
													<p>Killer Men Red Printed V-Neck T-Shirt</p>
													
												</div>
												
											</div>
										</div>
									</div>
									<div class="col-sm-3">
										<div class="product-image-wrapper">
											<div class="single-products">
												<div class="productinfo text-center">
													<img src="Product_Image/c.jpeg" width="150" height"300" />
													<h2>&#8377;950</h2>
													<p>Killer Men Red Printed V-Neck T-Shirt</p>
													
												</div>
												
											</div>
										</div>
									</div>
                                    <div class="col-sm-3">
										<div class="product-image-wrapper">
											<div class="single-products">
												<div class="productinfo text-center">
													<img src="Product_Image/a.jpeg" width="150" height"300" />
													<h2>&#8377;800</h2>
													<p>Killer Men Red Printed V-Neck T-Shirt</p>
													</div>
												
											</div>
										</div>
									</div>
								</div>
								<div class="item">	
									<div class="col-sm-3">
										<div class="product-image-wrapper">
											<div class="single-products">
												<div class="productinfo text-center">
												<img src="Product_Image/bb.jpeg" width="150" height"300" />
													<h2>&#8377;444</h2>
													<p>Killer Men Red Printed V-Neck T-Shirt</p>
													
												</div>
												
											</div>
										</div>
									</div>
									<div class="col-sm-3">
										<div class="product-image-wrapper">
											<div class="single-products">
												<div class="productinfo text-center">
													<img src="Product_Image/dd.jpeg" width="150" height"300" />
													<h2>&#8377;849</h2>
													<p>Killer Men Red Printed V-Neck T-Shirt</p>
													
												</div>
												
											</div>
										</div>
									</div>
									<div class="col-sm-3">
										<div class="product-image-wrapper">
											<div class="single-products">
												<div class="productinfo text-center">
												<img src="Product_Image/cc.jpeg" width="150" height"300" />
													<h2>&#8377;844</h2>
													<p>Killer Men Red Printed V-Neck T-Shirt</p>
													
												</div>
												
											</div>
										</div>
									</div>
                                    <div class="col-sm-3">
										<div class="product-image-wrapper">
											<div class="single-products">
												<div class="productinfo text-center">
												<img src="Product_Image/aaaaa.jpeg" width="150" height"300" />
													<h2>&#8377;844</h2>
													<p>Killer Men Red Printed V-Neck T-Shirt</p>
												</div>
												
											</div>
										</div>
									</div>
								</div>
							</div>
							 <a class="left recommended-item-control" href="#recommended-item-carousel" data-slide="prev">
								<i class=" glyphicon glyphicon-chevron-left"></i>
							  </a>
							  <a class="right recommended-item-control" href="#recommended-item-carousel" data-slide="next">
								<i class=" glyphicon glyphicon-chevron-right"></i>
							  </a>			
						</div>
					</div>
       
          </div>
   
   </div>
   <div class="row" style=" margin-top:30px;" >
   <span><h2 style="color:Gray">Best Selling Shirts</h2><a href="T-Shirts.aspx">MORE</a></span>
    <div class="col-sm-12">
        
        <div class="recommended_items"><!--recommended_items-->
					
						
						<div id="Div1" class="carousel slide" data-ride="carousel">
							<div class="carousel-inner">
								<div class="item active">	
									<div class="col-sm-3">
										<div class="product-image-wrapper">
											<div class="single-products">
												<div class="productinfo text-center">
													<img src="Product_Image/b4545.jpeg" width="150" height"300" />
													<h2>&#8377;719</h2>
													<p>Levis Solid Men Round Neck Red T-Shirt</p>
													
												</div>
												
											</div>
										</div>
									</div>
									<div class="col-sm-3">
										<div class="product-image-wrapper">
											<div class="single-products">
												<div class="productinfo text-center">
													<img src="Product_Image/e.jpg" width="150" height"300" />
													<h2>&#8377;495</h2>
													<p>Basics Printed Men Round Neck Beige T-Shirt</p>
													
												</div>
												
											</div>
										</div>
									</div>
									<div class="col-sm-3">
										<div class="product-image-wrapper">
											<div class="single-products">
												<div class="productinfo text-center">
													<img src="Product_Image/a5.jpeg" width="150" height"300" />
													<h2>&#8377;599</h2>
													<p>Jack & Jones Men White & Blue Printed Round Neck T-shirt</p>
													
												</div>
												
											</div>
										</div>
									</div>
                                    <div class="col-sm-3">
										<div class="product-image-wrapper">
											<div class="single-products">
												<div class="productinfo text-center">
													<img src="Product_Image/a4.jpeg" width="150" height"300" />
													<h2>&#8377;389</h2>
													<p>Pepe Jeans Men Black Printed Round Neck T-shirt</p>
													</div>
												
											</div>
										</div>
									</div>
								</div>
								<div class="item">	
									<div class="col-sm-3">
										<div class="product-image-wrapper">
											<div class="single-products">
												<div class="productinfo text-center">
										<img src="Product_Image/e.jpeg" width="150" height"300" />
													<h2>&#8377;844</h2>
													<p>Killer Men Red Printed V-Neck T-Shirt</p>
													
												</div>
												
											</div>
										</div>
									</div>
									<div class="col-sm-3">
										<div class="product-image-wrapper">
											<div class="single-products">
												<div class="productinfo text-center">
														<img src="Product_Image/a2.jpeg" width="150" height"300" />
													<h2>&#8377;818</h2>
													<p>Basics Solid Men Round Neck Black T-Shirt</p>
													
													
												</div>
												
											</div>
										</div>
									</div>
									<div class="col-sm-3">
										<div class="product-image-wrapper">
											<div class="single-products">
												<div class="productinfo text-center">
													<img src="Product_Image/a1.jpeg" width="150" height"300" />
													<h2>&#8377;935</h2>
													<p>Levis Solid Men Round Neck Blue T-Shirt</p>
													
												</div>
												
											</div>
										</div>
									</div>
                                    <div class="col-sm-3">
										<div class="product-image-wrapper">
											<div class="single-products">
												<div class="productinfo text-center">
													<img src="Product_Image/i.jpeg" width="150" height"300" />
													<h2>&#8377;881</h2>
													<p>Levis Solid Men Round Neck Black, White T-Shirt</p>
													
												</div>
												
											</div>
										</div>
									</div>
								</div>
							</div>
							 <a class="left recommended-item-control" href="#recommended-item-carousel" data-slide="prev">
								<i class=" glyphicon glyphicon-chevron-left"></i>
							  </a>
							  <a class="right recommended-item-control" href="#recommended-item-carousel" data-slide="next">
								<i class=" glyphicon glyphicon-chevron-right"></i>
							  </a>			
						</div>
					</div>
       
          </div>
   
   </div>
   <div class="row" style=" margin-top:30px;" >
   <h2 style="color:Gray">Best Selling Jeans</h2>
    <div class="col-sm-12">
        
        <div class="recommended_items"><!--recommended_items-->
						
           
						
						<div id="Div2" class="carousel slide" data-ride="carousel">
							<div class="carousel-inner">
								<div class="item active">	
									<div class="col-sm-3">
										<div class="product-image-wrapper">
											<div class="single-products">
												<div class="productinfo text-center">
													<img src="images/homeimg/1.jpg" width="100" height"300" />
													<h2>&#8377;799</h2>
													<p>HIGHLANDER Men Blue Slim Tapered Fit Mildly </p>
													
												</div>
												
											</div>
										</div>
									</div>
									<div class="col-sm-3">
										<div class="product-image-wrapper">
											<div class="single-products">
												<div class="productinfo text-center">
													<img src="images/homeimg/2.jpg" width="100" height"300" />
													<h2>&#8377;899</h2>
													<p>John Players Men Blue Regular Fit Mid-Rise Jeans </p>
												</div>
												
											</div>
										</div>
									</div>
									<div class="col-sm-3">
										<div class="product-image-wrapper">
											<div class="single-products">
												<div class="productinfo text-center">
													<img src="images/homeimg/3.jpg" width="100" height"300" />
													<h2>&#8377;1199</h2>
													<p>HRX by Hrithik Roshan Men Blue Skinny Fit Mid-Rise </p>
												</div>
												
											</div>
										</div>
									</div>
                                    <div class="col-sm-3">
										<div class="product-image-wrapper">
											<div class="single-products">
												<div class="productinfo text-center">
					                       		<img src="images/homeimg/4.jpg" width="100" height"300" />
													<h2>&#8377;1189</h2>
													<p>Roadster Men Blue Skinny Fit Mid-Rise Mildly  </p>
													</div>
												
											</div>
										</div>
									</div>
								</div>
								<div class="item">	
									<div class="col-sm-3">
										<div class="product-image-wrapper">
											<div class="single-products">
												<div class="productinfo text-center">
												<img src="images/homeimg/5.jpg" width="100" height"300" />
													<h2>&#8377;839</h2>
													<p>Roadster Men Blue Slim Fit Mid-Rise Clean Look Jeans </p>
												</div>
												
											</div>
										</div>
									</div>
									<div class="col-sm-3">
										<div class="product-image-wrapper">
											<div class="single-products">
												<div class="productinfo text-center">
												<img src="images/homeimg/6.jpg" width="100" height"300" />
													<h2>&#8377;1169</h2>
													<p>John Players Men Black Slim Fit Mid-Rise Clean Look Jeans </p>
												</div>
												
											</div>
										</div>
									</div>
									<div class="col-sm-3">
										<div class="product-image-wrapper">
											<div class="single-products">
												<div class="productinfo text-center">
												<img src="images/homeimg/7.jpg" width="100" height"300" />
													<h2>&#8377;1189</h2>
													<p>ether Men White Regular Fit Mid-Rise Clean Look </p>
												</div>
												
											</div>
										</div>
									</div>
                                    <div class="col-sm-3">
										<div class="product-image-wrapper">
											<div class="single-products">
												<div class="productinfo text-center">
												<img src="images/homeimg/8.jpg" width="100" height"300" />
													<h2>&#8377;999</h2>
													<p>GANT Blue Chip Narrow Fit Jeans </p>
												</div>
												
											</div>
										</div>
									</div>
								</div>
							</div>
							 <a class="left recommended-item-control" href="#recommended-item-carousel" data-slide="prev">
								<i class=" glyphicon glyphicon-chevron-left"></i>
							  </a>
							  <a class="right recommended-item-control" href="#recommended-item-carousel" data-slide="next">
								<i class=" glyphicon glyphicon-chevron-right"></i>
							  </a>			
						</div>
					</div>
       
          </div>
   
   </div>
   
   
   <!--End meddle div-->
   </div>
</asp:Content>

