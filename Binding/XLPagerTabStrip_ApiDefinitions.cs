using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;
using XLPagerTabStrip;

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern const CGPathRef FXPageControlDotShapeCircle;
	[Field ("FXPageControlDotShapeCircle", "__Internal")]
	unsafe CGPathRef* FXPageControlDotShapeCircle { get; }

	// extern const CGPathRef FXPageControlDotShapeSquare;
	[Field ("FXPageControlDotShapeSquare", "__Internal")]
	unsafe CGPathRef* FXPageControlDotShapeSquare { get; }

	// extern const CGPathRef FXPageControlDotShapeTriangle;
	[Field ("FXPageControlDotShapeTriangle", "__Internal")]
	unsafe CGPathRef* FXPageControlDotShapeTriangle { get; }
}

// @interface FXPageControl : UIControl
[BaseType (typeof(UIControl))]
interface FXPageControl
{
	// -(void)setUp;
	[Export ("setUp")]
	void SetUp ();

	// -(CGSize)sizeForNumberOfPages:(NSInteger)pageCount;
	[Export ("sizeForNumberOfPages:")]
	CGSize SizeForNumberOfPages (nint pageCount);

	// -(void)updateCurrentPageDisplay;
	[Export ("updateCurrentPageDisplay")]
	void UpdateCurrentPageDisplay ();

	[Wrap ("WeakDelegate")]
	FXPageControlDelegate Delegate { get; set; }

	// @property (nonatomic, unsafe_unretained) id<FXPageControlDelegate> delegate __attribute__((iboutlet));
	[NullAllowed, Export ("delegate", ArgumentSemantic.Assign)]
	NSObject WeakDelegate { get; set; }

	// @property (assign, nonatomic) NSInteger currentPage;
	[Export ("currentPage")]
	nint CurrentPage { get; set; }

	// @property (assign, nonatomic) NSInteger numberOfPages;
	[Export ("numberOfPages")]
	nint NumberOfPages { get; set; }

	// @property (assign, nonatomic) BOOL defersCurrentPageDisplay;
	[Export ("defersCurrentPageDisplay")]
	bool DefersCurrentPageDisplay { get; set; }

	// @property (assign, nonatomic) BOOL hidesForSinglePage;
	[Export ("hidesForSinglePage")]
	bool HidesForSinglePage { get; set; }

	// @property (getter = isWrapEnabled, assign, nonatomic) BOOL wrapEnabled;
	[Export ("wrapEnabled")]
	bool WrapEnabled { [Bind ("isWrapEnabled")] get; set; }

	// @property (getter = isVertical, assign, nonatomic) BOOL vertical;
	[Export ("vertical")]
	bool Vertical { [Bind ("isVertical")] get; set; }

	// @property (nonatomic, strong) UIImage * dotImage;
	[Export ("dotImage", ArgumentSemantic.Strong)]
	UIImage DotImage { get; set; }

	// @property (assign, nonatomic) CGPathRef dotShape;
	[Export ("dotShape", ArgumentSemantic.Assign)]
	unsafe CGPathRef* DotShape { get; set; }

	// @property (assign, nonatomic) CGFloat dotSize;
	[Export ("dotSize")]
	nfloat DotSize { get; set; }

	// @property (nonatomic, strong) UIColor * dotColor;
	[Export ("dotColor", ArgumentSemantic.Strong)]
	UIColor DotColor { get; set; }

	// @property (nonatomic, strong) UIColor * dotShadowColor;
	[Export ("dotShadowColor", ArgumentSemantic.Strong)]
	UIColor DotShadowColor { get; set; }

	// @property (assign, nonatomic) CGFloat dotShadowBlur;
	[Export ("dotShadowBlur")]
	nfloat DotShadowBlur { get; set; }

	// @property (assign, nonatomic) CGSize dotShadowOffset;
	[Export ("dotShadowOffset", ArgumentSemantic.Assign)]
	CGSize DotShadowOffset { get; set; }

	// @property (nonatomic, strong) UIImage * selectedDotImage;
	[Export ("selectedDotImage", ArgumentSemantic.Strong)]
	UIImage SelectedDotImage { get; set; }

	// @property (assign, nonatomic) CGPathRef selectedDotShape;
	[Export ("selectedDotShape", ArgumentSemantic.Assign)]
	unsafe CGPathRef* SelectedDotShape { get; set; }

	// @property (assign, nonatomic) CGFloat selectedDotSize;
	[Export ("selectedDotSize")]
	nfloat SelectedDotSize { get; set; }

	// @property (nonatomic, strong) UIColor * selectedDotColor;
	[Export ("selectedDotColor", ArgumentSemantic.Strong)]
	UIColor SelectedDotColor { get; set; }

	// @property (nonatomic, strong) UIColor * selectedDotShadowColor;
	[Export ("selectedDotShadowColor", ArgumentSemantic.Strong)]
	UIColor SelectedDotShadowColor { get; set; }

	// @property (assign, nonatomic) CGFloat selectedDotShadowBlur;
	[Export ("selectedDotShadowBlur")]
	nfloat SelectedDotShadowBlur { get; set; }

	// @property (assign, nonatomic) CGSize selectedDotShadowOffset;
	[Export ("selectedDotShadowOffset", ArgumentSemantic.Assign)]
	CGSize SelectedDotShadowOffset { get; set; }

	// @property (assign, nonatomic) CGFloat dotSpacing;
	[Export ("dotSpacing")]
	nfloat DotSpacing { get; set; }
}

// @protocol FXPageControlDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface FXPageControlDelegate
{
	// @optional -(UIImage *)pageControl:(FXPageControl *)pageControl imageForDotAtIndex:(NSInteger)index;
	[Export ("pageControl:imageForDotAtIndex:")]
	UIImage PageControl (FXPageControl pageControl, nint index);

	// @optional -(CGPathRef)pageControl:(FXPageControl *)pageControl shapeForDotAtIndex:(NSInteger)index;
	[Export ("pageControl:shapeForDotAtIndex:")]
	unsafe CGPathRef* PageControl (FXPageControl pageControl, nint index);

	// @optional -(UIColor *)pageControl:(FXPageControl *)pageControl colorForDotAtIndex:(NSInteger)index;
	[Export ("pageControl:colorForDotAtIndex:")]
	UIColor PageControl (FXPageControl pageControl, nint index);

	// @optional -(UIImage *)pageControl:(FXPageControl *)pageControl selectedImageForDotAtIndex:(NSInteger)index;
	[Export ("pageControl:selectedImageForDotAtIndex:")]
	UIImage PageControl (FXPageControl pageControl, nint index);

	// @optional -(CGPathRef)pageControl:(FXPageControl *)pageControl selectedShapeForDotAtIndex:(NSInteger)index;
	[Export ("pageControl:selectedShapeForDotAtIndex:")]
	unsafe CGPathRef* PageControl (FXPageControl pageControl, nint index);

	// @optional -(UIColor *)pageControl:(FXPageControl *)pageControl selectedColorForDotAtIndex:(NSInteger)index;
	[Export ("pageControl:selectedColorForDotAtIndex:")]
	UIColor PageControl (FXPageControl pageControl, nint index);
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern double XLPagerTabStripVersionNumber;
	[Field ("XLPagerTabStripVersionNumber", "__Internal")]
	double XLPagerTabStripVersionNumber { get; }

	// extern const unsigned char [] XLPagerTabStripVersionString;
	[Field ("XLPagerTabStripVersionString", "__Internal")]
	byte[] XLPagerTabStripVersionString { get; }
}

// @interface PagerTabStripViewController : UIViewController <UIScrollViewDelegate>
[BaseType (typeof(UIViewController))]
interface PagerTabStripViewController : IUIScrollViewDelegate
{
	// @property (nonatomic, weak) UIScrollView * _Null_unspecified containerView __attribute__((iboutlet));
	[Export ("containerView", ArgumentSemantic.Weak)]
	UIScrollView ContainerView { get; set; }

	// -(void)viewDidLoad;
	[Export ("viewDidLoad")]
	void ViewDidLoad ();

	// -(void)viewWillAppear:(BOOL)animated;
	[Export ("viewWillAppear:")]
	void ViewWillAppear (bool animated);

	// -(void)viewDidAppear:(BOOL)animated;
	[Export ("viewDidAppear:")]
	void ViewDidAppear (bool animated);

	// -(void)viewWillDisappear:(BOOL)animated;
	[Export ("viewWillDisappear:")]
	void ViewWillDisappear (bool animated);

	// -(void)viewDidDisappear:(BOOL)animated;
	[Export ("viewDidDisappear:")]
	void ViewDidDisappear (bool animated);

	// -(void)viewDidLayoutSubviews;
	[Export ("viewDidLayoutSubviews")]
	void ViewDidLayoutSubviews ();

	// @property (readonly, nonatomic) BOOL shouldAutomaticallyForwardAppearanceMethods;
	[Export ("shouldAutomaticallyForwardAppearanceMethods")]
	bool ShouldAutomaticallyForwardAppearanceMethods { get; }

	// -(void)scrollViewDidScroll:(UIScrollView * _Nonnull)scrollView;
	[Export ("scrollViewDidScroll:")]
	void ScrollViewDidScroll (UIScrollView scrollView);

	// -(void)scrollViewWillBeginDragging:(UIScrollView * _Nonnull)scrollView;
	[Export ("scrollViewWillBeginDragging:")]
	void ScrollViewWillBeginDragging (UIScrollView scrollView);

	// -(void)scrollViewDidEndScrollingAnimation:(UIScrollView * _Nonnull)scrollView;
	[Export ("scrollViewDidEndScrollingAnimation:")]
	void ScrollViewDidEndScrollingAnimation (UIScrollView scrollView);

	// -(void)viewWillTransitionToSize:(CGSize)size withTransitionCoordinator:(id<UIViewControllerTransitionCoordinator> _Nonnull)coordinator;
	[Export ("viewWillTransitionToSize:withTransitionCoordinator:")]
	void ViewWillTransitionToSize (CGSize size, UIViewControllerTransitionCoordinator coordinator);

	// -(instancetype _Nonnull)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil __attribute__((objc_designated_initializer));
	[Export ("initWithNibName:bundle:")]
	[DesignatedInitializer]
	IntPtr Constructor ([NullAllowed] string nibNameOrNil, [NullAllowed] NSBundle nibBundleOrNil);

	// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
	[Export ("initWithCoder:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSCoder aDecoder);
}

// @interface BarPagerTabStripViewController : PagerTabStripViewController
[BaseType (typeof(PagerTabStripViewController))]
interface BarPagerTabStripViewController
{
	// @property (nonatomic, weak) BarView * _Null_unspecified barView __attribute__((iboutlet));
	[Export ("barView", ArgumentSemantic.Weak)]
	BarView BarView { get; set; }

	// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
	[Export ("initWithCoder:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSCoder aDecoder);

	// -(instancetype _Nonnull)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil __attribute__((objc_designated_initializer));
	[Export ("initWithNibName:bundle:")]
	[DesignatedInitializer]
	IntPtr Constructor ([NullAllowed] string nibNameOrNil, [NullAllowed] NSBundle nibBundleOrNil);

	// -(void)viewDidLoad;
	[Export ("viewDidLoad")]
	void ViewDidLoad ();

	// -(void)viewWillAppear:(BOOL)animated;
	[Export ("viewWillAppear:")]
	void ViewWillAppear (bool animated);
}

// @interface BarView : UIView
[BaseType (typeof(UIView))]
interface BarView
{
	// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
	[Export ("initWithCoder:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSCoder aDecoder);

	// -(void)layoutSubviews;
	[Export ("layoutSubviews")]
	void LayoutSubviews ();
}

// @interface ButtonBarPagerTabStripViewController : PagerTabStripViewController <UICollectionViewDataSource, UICollectionViewDelegate>
[BaseType (typeof(PagerTabStripViewController))]
interface ButtonBarPagerTabStripViewController : IUICollectionViewDataSource, IUICollectionViewDelegate
{
	// @property (nonatomic, weak) ButtonBarView * _Null_unspecified buttonBarView __attribute__((iboutlet));
	[Export ("buttonBarView", ArgumentSemantic.Weak)]
	ButtonBarView ButtonBarView { get; set; }

	// -(instancetype _Nonnull)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil __attribute__((objc_designated_initializer));
	[Export ("initWithNibName:bundle:")]
	[DesignatedInitializer]
	IntPtr Constructor ([NullAllowed] string nibNameOrNil, [NullAllowed] NSBundle nibBundleOrNil);

	// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
	[Export ("initWithCoder:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSCoder aDecoder);

	// -(void)viewDidLoad;
	[Export ("viewDidLoad")]
	void ViewDidLoad ();

	// -(void)viewWillAppear:(BOOL)animated;
	[Export ("viewWillAppear:")]
	void ViewWillAppear (bool animated);

	// -(void)viewDidLayoutSubviews;
	[Export ("viewDidLayoutSubviews")]
	void ViewDidLayoutSubviews ();

	// -(CGSize)collectionView:(UICollectionView * _Nonnull)collectionView layout:(UICollectionViewLayout * _Nonnull)collectionViewLayout sizeForItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result));
	[Export ("collectionView:layout:sizeForItemAtIndexPath:")]
	CGSize CollectionView (UICollectionView collectionView, UICollectionViewLayout collectionViewLayout, NSIndexPath indexPath);

	// -(void)collectionView:(UICollectionView * _Nonnull)collectionView didSelectItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
	[Export ("collectionView:didSelectItemAtIndexPath:")]
	void CollectionView (UICollectionView collectionView, NSIndexPath indexPath);

	// -(NSInteger)collectionView:(UICollectionView * _Nonnull)collectionView numberOfItemsInSection:(NSInteger)section __attribute__((warn_unused_result));
	[Export ("collectionView:numberOfItemsInSection:")]
	nint CollectionView (UICollectionView collectionView, nint section);

	// -(UICollectionViewCell * _Nonnull)collectionView:(UICollectionView * _Nonnull)collectionView cellForItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result));
	[Export ("collectionView:cellForItemAtIndexPath:")]
	UICollectionViewCell CollectionView (UICollectionView collectionView, NSIndexPath indexPath);

	// -(void)scrollViewDidEndScrollingAnimation:(UIScrollView * _Nonnull)scrollView;
	[Export ("scrollViewDidEndScrollingAnimation:")]
	void ScrollViewDidEndScrollingAnimation (UIScrollView scrollView);
}

// @interface ButtonBarView : UICollectionView
[BaseType (typeof(UICollectionView))]
interface ButtonBarView
{
	// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
	[Export ("initWithCoder:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSCoder aDecoder);

	// -(instancetype _Nonnull)initWithFrame:(CGRect)frame collectionViewLayout:(UICollectionViewLayout * _Nonnull)layout __attribute__((objc_designated_initializer));
	[Export ("initWithFrame:collectionViewLayout:")]
	[DesignatedInitializer]
	IntPtr Constructor (CGRect frame, UICollectionViewLayout layout);

	// -(void)layoutSubviews;
	[Export ("layoutSubviews")]
	void LayoutSubviews ();
}

// @interface ButtonBarViewCell : UICollectionViewCell
[BaseType (typeof(UICollectionViewCell))]
interface ButtonBarViewCell
{
	// @property (nonatomic, strong) UIImageView * _Null_unspecified imageView __attribute__((iboutlet));
	[Export ("imageView", ArgumentSemantic.Strong)]
	UIImageView ImageView { get; set; }

	// @property (nonatomic, strong) UILabel * _Null_unspecified label __attribute__((iboutlet));
	[Export ("label", ArgumentSemantic.Strong)]
	UILabel Label { get; set; }

	// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
	[Export ("initWithCoder:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSCoder aDecoder);

	// @property (getter = isSelected, nonatomic) BOOL selected;
	[Export ("selected")]
	bool Selected { [Bind ("isSelected")] get; set; }
}

// @interface SegmentedPagerTabStripViewController : PagerTabStripViewController
[BaseType (typeof(PagerTabStripViewController))]
interface SegmentedPagerTabStripViewController
{
	// @property (nonatomic, weak) UISegmentedControl * _Null_unspecified segmentedControl __attribute__((iboutlet));
	[Export ("segmentedControl", ArgumentSemantic.Weak)]
	UISegmentedControl SegmentedControl { get; set; }

	// -(instancetype _Nonnull)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil __attribute__((objc_designated_initializer));
	[Export ("initWithNibName:bundle:")]
	[DesignatedInitializer]
	IntPtr Constructor ([NullAllowed] string nibNameOrNil, [NullAllowed] NSBundle nibBundleOrNil);

	// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
	[Export ("initWithCoder:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSCoder aDecoder);

	// -(void)viewDidLoad;
	[Export ("viewDidLoad")]
	void ViewDidLoad ();

	// -(void)scrollViewDidEndScrollingAnimation:(UIScrollView * _Nonnull)scrollView;
	[Export ("scrollViewDidEndScrollingAnimation:")]
	void ScrollViewDidEndScrollingAnimation (UIScrollView scrollView);
}

// @interface TwitterPagerTabStripViewController : PagerTabStripViewController
[BaseType (typeof(PagerTabStripViewController))]
interface TwitterPagerTabStripViewController
{
	// -(instancetype _Nonnull)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil __attribute__((objc_designated_initializer));
	[Export ("initWithNibName:bundle:")]
	[DesignatedInitializer]
	IntPtr Constructor ([NullAllowed] string nibNameOrNil, [NullAllowed] NSBundle nibBundleOrNil);

	// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
	[Export ("initWithCoder:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSCoder aDecoder);

	// -(void)viewDidLoad;
	[Export ("viewDidLoad")]
	void ViewDidLoad ();

	// -(void)observeValueForKeyPath:(NSString * _Nullable)keyPath ofObject:(id _Nullable)object change:(NSDictionary<NSKeyValueChangeKey,id> * _Nullable)change context:(void * _Nullable)context;
	[Export ("observeValueForKeyPath:ofObject:change:context:")]
	unsafe void ObserveValueForKeyPath ([NullAllowed] string keyPath, [NullAllowed] NSObject @object, [NullAllowed] NSDictionary<NSString, NSObject> change, [NullAllowed] void* context);

	// -(void)viewDidLayoutSubviews;
	[Export ("viewDidLayoutSubviews")]
	void ViewDidLayoutSubviews ();
}
