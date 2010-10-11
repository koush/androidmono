namespace android
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class R : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static R()
		{
			InitJNI();
		}
		internal R(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class anim : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static anim()
			{
				InitJNI();
			}
			internal anim(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _anim3;
			public anim()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.R.anim.staticClass, global::android.R.anim._anim3);
				Init(@__env, handle);
			}
			public static int accelerate_decelerate_interpolator
			{
				get
				{
					return 17432580;
				}
			}
			public static int accelerate_interpolator
			{
				get
				{
					return 17432581;
				}
			}
			public static int anticipate_interpolator
			{
				get
				{
					return 17432583;
				}
			}
			public static int anticipate_overshoot_interpolator
			{
				get
				{
					return 17432585;
				}
			}
			public static int bounce_interpolator
			{
				get
				{
					return 17432586;
				}
			}
			public static int cycle_interpolator
			{
				get
				{
					return 17432588;
				}
			}
			public static int decelerate_interpolator
			{
				get
				{
					return 17432582;
				}
			}
			public static int fade_in
			{
				get
				{
					return 17432576;
				}
			}
			public static int fade_out
			{
				get
				{
					return 17432577;
				}
			}
			public static int linear_interpolator
			{
				get
				{
					return 17432587;
				}
			}
			public static int overshoot_interpolator
			{
				get
				{
					return 17432584;
				}
			}
			public static int slide_in_left
			{
				get
				{
					return 17432578;
				}
			}
			public static int slide_out_right
			{
				get
				{
					return 17432579;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.R.anim.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/R$anim"));
				global::android.R.anim._anim3 = @__env.GetMethodIDNoThrow(global::android.R.anim.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class array : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static array()
			{
				InitJNI();
			}
			internal array(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _array4;
			public array()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.R.array.staticClass, global::android.R.array._array4);
				Init(@__env, handle);
			}
			public static int emailAddressTypes
			{
				get
				{
					return 17235968;
				}
			}
			public static int imProtocols
			{
				get
				{
					return 17235969;
				}
			}
			public static int organizationTypes
			{
				get
				{
					return 17235970;
				}
			}
			public static int phoneTypes
			{
				get
				{
					return 17235971;
				}
			}
			public static int postalAddressTypes
			{
				get
				{
					return 17235972;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.R.array.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/R$array"));
				global::android.R.array._array4 = @__env.GetMethodIDNoThrow(global::android.R.array.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class attr : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static attr()
			{
				InitJNI();
			}
			internal attr(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _attr5;
			public attr()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.R.attr.staticClass, global::android.R.attr._attr5);
				Init(@__env, handle);
			}
			public static int absListViewStyle
			{
				get
				{
					return 16842858;
				}
			}
			public static int accountPreferences
			{
				get
				{
					return 16843423;
				}
			}
			public static int accountType
			{
				get
				{
					return 16843407;
				}
			}
			public static int action
			{
				get
				{
					return 16842797;
				}
			}
			public static int activityCloseEnterAnimation
			{
				get
				{
					return 16842938;
				}
			}
			public static int activityCloseExitAnimation
			{
				get
				{
					return 16842939;
				}
			}
			public static int activityOpenEnterAnimation
			{
				get
				{
					return 16842936;
				}
			}
			public static int activityOpenExitAnimation
			{
				get
				{
					return 16842937;
				}
			}
			public static int addStatesFromChildren
			{
				get
				{
					return 16842992;
				}
			}
			public static int adjustViewBounds
			{
				get
				{
					return 16843038;
				}
			}
			public static int alertDialogStyle
			{
				get
				{
					return 16842845;
				}
			}
			public static int allowBackup
			{
				get
				{
					return 16843392;
				}
			}
			public static int allowClearUserData
			{
				get
				{
					return 16842757;
				}
			}
			public static int allowSingleTap
			{
				get
				{
					return 16843353;
				}
			}
			public static int allowTaskReparenting
			{
				get
				{
					return 16843268;
				}
			}
			public static int alphabeticShortcut
			{
				get
				{
					return 16843235;
				}
			}
			public static int alwaysDrawnWithCache
			{
				get
				{
					return 16842991;
				}
			}
			public static int alwaysRetainTaskState
			{
				get
				{
					return 16843267;
				}
			}
			public static int angle
			{
				get
				{
					return 16843168;
				}
			}
			public static int animateOnClick
			{
				get
				{
					return 16843356;
				}
			}
			public static int animation
			{
				get
				{
					return 16843213;
				}
			}
			public static int animationCache
			{
				get
				{
					return 16842989;
				}
			}
			public static int animationDuration
			{
				get
				{
					return 16843026;
				}
			}
			public static int animationOrder
			{
				get
				{
					return 16843214;
				}
			}
			public static int antialias
			{
				get
				{
					return 16843034;
				}
			}
			public static int anyDensity
			{
				get
				{
					return 16843372;
				}
			}
			public static int apiKey
			{
				get
				{
					return 16843281;
				}
			}
			public static int author
			{
				get
				{
					return 16843444;
				}
			}
			public static int authorities
			{
				get
				{
					return 16842776;
				}
			}
			public static int autoCompleteTextViewStyle
			{
				get
				{
					return 16842859;
				}
			}
			public static int autoLink
			{
				get
				{
					return 16842928;
				}
			}
			public static int autoStart
			{
				get
				{
					return 16843445;
				}
			}
			public static int autoText
			{
				get
				{
					return 16843114;
				}
			}
			public static int autoUrlDetect
			{
				get
				{
					return 16843404;
				}
			}
			public static int background
			{
				get
				{
					return 16842964;
				}
			}
			public static int backgroundDimAmount
			{
				get
				{
					return 16842802;
				}
			}
			public static int backgroundDimEnabled
			{
				get
				{
					return 16843295;
				}
			}
			public static int backupAgent
			{
				get
				{
					return 16843391;
				}
			}
			public static int baselineAlignBottom
			{
				get
				{
					return 16843042;
				}
			}
			public static int baselineAligned
			{
				get
				{
					return 16843046;
				}
			}
			public static int baselineAlignedChildIndex
			{
				get
				{
					return 16843047;
				}
			}
			public static int bottom
			{
				get
				{
					return 16843184;
				}
			}
			public static int bottomBright
			{
				get
				{
					return 16842957;
				}
			}
			public static int bottomDark
			{
				get
				{
					return 16842953;
				}
			}
			public static int bottomLeftRadius
			{
				get
				{
					return 16843179;
				}
			}
			public static int bottomMedium
			{
				get
				{
					return 16842958;
				}
			}
			public static int bottomOffset
			{
				get
				{
					return 16843351;
				}
			}
			public static int bottomRightRadius
			{
				get
				{
					return 16843180;
				}
			}
			public static int bufferType
			{
				get
				{
					return 16843086;
				}
			}
			public static int button
			{
				get
				{
					return 16843015;
				}
			}
			public static int buttonStyle
			{
				get
				{
					return 16842824;
				}
			}
			public static int buttonStyleInset
			{
				get
				{
					return 16842826;
				}
			}
			public static int buttonStyleSmall
			{
				get
				{
					return 16842825;
				}
			}
			public static int buttonStyleToggle
			{
				get
				{
					return 16842827;
				}
			}
			public static int cacheColorHint
			{
				get
				{
					return 16843009;
				}
			}
			public static int candidatesTextStyleSpans
			{
				get
				{
					return 16843312;
				}
			}
			public static int capitalize
			{
				get
				{
					return 16843113;
				}
			}
			public static int centerBright
			{
				get
				{
					return 16842956;
				}
			}
			public static int centerColor
			{
				get
				{
					return 16843275;
				}
			}
			public static int centerDark
			{
				get
				{
					return 16842952;
				}
			}
			public static int centerMedium
			{
				get
				{
					return 16842959;
				}
			}
			public static int centerX
			{
				get
				{
					return 16843170;
				}
			}
			public static int centerY
			{
				get
				{
					return 16843171;
				}
			}
			public static int checkBoxPreferenceStyle
			{
				get
				{
					return 16842895;
				}
			}
			public static int checkMark
			{
				get
				{
					return 16843016;
				}
			}
			public static int checkable
			{
				get
				{
					return 16843237;
				}
			}
			public static int checkableBehavior
			{
				get
				{
					return 16843232;
				}
			}
			public static int checkboxStyle
			{
				get
				{
					return 16842860;
				}
			}
			public static int @checked
			{
				get
				{
					return 16843014;
				}
			}
			public static int checkedButton
			{
				get
				{
					return 16843080;
				}
			}
			public static int childDivider
			{
				get
				{
					return 16843025;
				}
			}
			public static int childIndicator
			{
				get
				{
					return 16843020;
				}
			}
			public static int childIndicatorLeft
			{
				get
				{
					return 16843023;
				}
			}
			public static int childIndicatorRight
			{
				get
				{
					return 16843024;
				}
			}
			public static int choiceMode
			{
				get
				{
					return 16843051;
				}
			}
			public static int clearTaskOnLaunch
			{
				get
				{
					return 16842773;
				}
			}
			public static int clickable
			{
				get
				{
					return 16842981;
				}
			}
			public static int clipChildren
			{
				get
				{
					return 16842986;
				}
			}
			public static int clipOrientation
			{
				get
				{
					return 16843274;
				}
			}
			public static int clipToPadding
			{
				get
				{
					return 16842987;
				}
			}
			public static int codes
			{
				get
				{
					return 16843330;
				}
			}
			public static int collapseColumns
			{
				get
				{
					return 16843083;
				}
			}
			public static int color
			{
				get
				{
					return 16843173;
				}
			}
			public static int colorBackground
			{
				get
				{
					return 16842801;
				}
			}
			public static int colorBackgroundCacheHint
			{
				get
				{
					return 16843435;
				}
			}
			public static int colorForeground
			{
				get
				{
					return 16842800;
				}
			}
			public static int colorForegroundInverse
			{
				get
				{
					return 16843270;
				}
			}
			public static int columnDelay
			{
				get
				{
					return 16843215;
				}
			}
			public static int columnWidth
			{
				get
				{
					return 16843031;
				}
			}
			public static int completionHint
			{
				get
				{
					return 16843122;
				}
			}
			public static int completionHintView
			{
				get
				{
					return 16843123;
				}
			}
			public static int completionThreshold
			{
				get
				{
					return 16843124;
				}
			}
			public static int configChanges
			{
				get
				{
					return 16842783;
				}
			}
			public static int configure
			{
				get
				{
					return 16843357;
				}
			}
			public static int constantSize
			{
				get
				{
					return 16843158;
				}
			}
			public static int content
			{
				get
				{
					return 16843355;
				}
			}
			public static int contentAuthority
			{
				get
				{
					return 16843408;
				}
			}
			public static int contentDescription
			{
				get
				{
					return 16843379;
				}
			}
			public static int cropToPadding
			{
				get
				{
					return 16843043;
				}
			}
			public static int cursorVisible
			{
				get
				{
					return 16843090;
				}
			}
			public static int cycles
			{
				get
				{
					return 16843220;
				}
			}
			public static int dashGap
			{
				get
				{
					return 16843175;
				}
			}
			public static int dashWidth
			{
				get
				{
					return 16843174;
				}
			}
			public static int data
			{
				get
				{
					return 16842798;
				}
			}
			public static int debuggable
			{
				get
				{
					return 16842767;
				}
			}
			public static int defaultValue
			{
				get
				{
					return 16843245;
				}
			}
			public static int delay
			{
				get
				{
					return 16843212;
				}
			}
			public static int dependency
			{
				get
				{
					return 16843244;
				}
			}
			public static int descendantFocusability
			{
				get
				{
					return 16842993;
				}
			}
			public static int description
			{
				get
				{
					return 16842784;
				}
			}
			public static int detachWallpaper
			{
				get
				{
					return 16843430;
				}
			}
			public static int detailColumn
			{
				get
				{
					return 16843427;
				}
			}
			public static int detailSocialSummary
			{
				get
				{
					return 16843428;
				}
			}
			public static int dial
			{
				get
				{
					return 16843010;
				}
			}
			public static int dialogIcon
			{
				get
				{
					return 16843252;
				}
			}
			public static int dialogLayout
			{
				get
				{
					return 16843255;
				}
			}
			public static int dialogMessage
			{
				get
				{
					return 16843251;
				}
			}
			public static int dialogPreferenceStyle
			{
				get
				{
					return 16842897;
				}
			}
			public static int dialogTitle
			{
				get
				{
					return 16843250;
				}
			}
			public static int digits
			{
				get
				{
					return 16843110;
				}
			}
			public static int direction
			{
				get
				{
					return 16843217;
				}
			}
			public static int directionPriority
			{
				get
				{
					return 16843218;
				}
			}
			public static int disableDependentsState
			{
				get
				{
					return 16843249;
				}
			}
			public static int disabledAlpha
			{
				get
				{
					return 16842803;
				}
			}
			public static int dither
			{
				get
				{
					return 16843036;
				}
			}
			public static int divider
			{
				get
				{
					return 16843049;
				}
			}
			public static int dividerHeight
			{
				get
				{
					return 16843050;
				}
			}
			public static int drawSelectorOnTop
			{
				get
				{
					return 16843004;
				}
			}
			public static int drawable
			{
				get
				{
					return 16843161;
				}
			}
			public static int drawableBottom
			{
				get
				{
					return 16843118;
				}
			}
			public static int drawableLeft
			{
				get
				{
					return 16843119;
				}
			}
			public static int drawablePadding
			{
				get
				{
					return 16843121;
				}
			}
			public static int drawableRight
			{
				get
				{
					return 16843120;
				}
			}
			public static int drawableTop
			{
				get
				{
					return 16843117;
				}
			}
			public static int drawingCacheQuality
			{
				get
				{
					return 16842984;
				}
			}
			public static int dropDownAnchor
			{
				get
				{
					return 16843363;
				}
			}
			public static int dropDownHeight
			{
				get
				{
					return 16843395;
				}
			}
			public static int dropDownHintAppearance
			{
				get
				{
					return 16842888;
				}
			}
			public static int dropDownHorizontalOffset
			{
				get
				{
					return 16843436;
				}
			}
			public static int dropDownItemStyle
			{
				get
				{
					return 16842886;
				}
			}
			public static int dropDownListViewStyle
			{
				get
				{
					return 16842861;
				}
			}
			public static int dropDownSelector
			{
				get
				{
					return 16843125;
				}
			}
			public static int dropDownVerticalOffset
			{
				get
				{
					return 16843437;
				}
			}
			public static int dropDownWidth
			{
				get
				{
					return 16843362;
				}
			}
			public static int duplicateParentState
			{
				get
				{
					return 16842985;
				}
			}
			public static int duration
			{
				get
				{
					return 16843160;
				}
			}
			public static int editTextPreferenceStyle
			{
				get
				{
					return 16842898;
				}
			}
			public static int editTextStyle
			{
				get
				{
					return 16842862;
				}
			}
			public static int editable
			{
				get
				{
					return 16843115;
				}
			}
			public static int editorExtras
			{
				get
				{
					return 16843300;
				}
			}
			public static int ellipsize
			{
				get
				{
					return 16842923;
				}
			}
			public static int ems
			{
				get
				{
					return 16843096;
				}
			}
			public static int enabled
			{
				get
				{
					return 16842766;
				}
			}
			public static int endColor
			{
				get
				{
					return 16843166;
				}
			}
			public static int endYear
			{
				get
				{
					return 16843133;
				}
			}
			public static int entries
			{
				get
				{
					return 16842930;
				}
			}
			public static int entryValues
			{
				get
				{
					return 16843256;
				}
			}
			public static int eventsInterceptionEnabled
			{
				get
				{
					return 16843389;
				}
			}
			public static int excludeFromRecents
			{
				get
				{
					return 16842775;
				}
			}
			public static int expandableListPreferredChildIndicatorLeft
			{
				get
				{
					return 16842834;
				}
			}
			public static int expandableListPreferredChildIndicatorRight
			{
				get
				{
					return 16842835;
				}
			}
			public static int expandableListPreferredChildPaddingLeft
			{
				get
				{
					return 16842831;
				}
			}
			public static int expandableListPreferredItemIndicatorLeft
			{
				get
				{
					return 16842832;
				}
			}
			public static int expandableListPreferredItemIndicatorRight
			{
				get
				{
					return 16842833;
				}
			}
			public static int expandableListPreferredItemPaddingLeft
			{
				get
				{
					return 16842830;
				}
			}
			public static int expandableListViewStyle
			{
				get
				{
					return 16842863;
				}
			}
			public static int expandableListViewWhiteStyle
			{
				get
				{
					return 16843446;
				}
			}
			public static int exported
			{
				get
				{
					return 16842768;
				}
			}
			public static int extraTension
			{
				get
				{
					return 16843371;
				}
			}
			public static int factor
			{
				get
				{
					return 16843219;
				}
			}
			public static int fadeDuration
			{
				get
				{
					return 16843384;
				}
			}
			public static int fadeEnabled
			{
				get
				{
					return 16843390;
				}
			}
			public static int fadeOffset
			{
				get
				{
					return 16843383;
				}
			}
			public static int fadeScrollbars
			{
				get
				{
					return 16843434;
				}
			}
			public static int fadingEdge
			{
				get
				{
					return 16842975;
				}
			}
			public static int fadingEdgeLength
			{
				get
				{
					return 16842976;
				}
			}
			public static int fastScrollEnabled
			{
				get
				{
					return 16843302;
				}
			}
			public static int fillAfter
			{
				get
				{
					return 16843197;
				}
			}
			public static int fillBefore
			{
				get
				{
					return 16843196;
				}
			}
			public static int fillEnabled
			{
				get
				{
					return 16843343;
				}
			}
			public static int fillViewport
			{
				get
				{
					return 16843130;
				}
			}
			public static int filter
			{
				get
				{
					return 16843035;
				}
			}
			public static int finishOnCloseSystemDialogs
			{
				get
				{
					return 16843431;
				}
			}
			public static int finishOnTaskLaunch
			{
				get
				{
					return 16842772;
				}
			}
			public static int fitsSystemWindows
			{
				get
				{
					return 16842973;
				}
			}
			public static int flipInterval
			{
				get
				{
					return 16843129;
				}
			}
			public static int focusable
			{
				get
				{
					return 16842970;
				}
			}
			public static int focusableInTouchMode
			{
				get
				{
					return 16842971;
				}
			}
			public static int footerDividersEnabled
			{
				get
				{
					return 16843311;
				}
			}
			public static int foreground
			{
				get
				{
					return 16843017;
				}
			}
			public static int foregroundGravity
			{
				get
				{
					return 16843264;
				}
			}
			public static int format
			{
				get
				{
					return 16843013;
				}
			}
			public static int freezesText
			{
				get
				{
					return 16843116;
				}
			}
			public static int fromAlpha
			{
				get
				{
					return 16843210;
				}
			}
			public static int fromDegrees
			{
				get
				{
					return 16843187;
				}
			}
			public static int fromXDelta
			{
				get
				{
					return 16843206;
				}
			}
			public static int fromXScale
			{
				get
				{
					return 16843202;
				}
			}
			public static int fromYDelta
			{
				get
				{
					return 16843208;
				}
			}
			public static int fromYScale
			{
				get
				{
					return 16843204;
				}
			}
			public static int fullBright
			{
				get
				{
					return 16842954;
				}
			}
			public static int fullDark
			{
				get
				{
					return 16842950;
				}
			}
			public static int functionalTest
			{
				get
				{
					return 16842787;
				}
			}
			public static int galleryItemBackground
			{
				get
				{
					return 16842828;
				}
			}
			public static int galleryStyle
			{
				get
				{
					return 16842864;
				}
			}
			public static int gestureColor
			{
				get
				{
					return 16843381;
				}
			}
			public static int gestureStrokeAngleThreshold
			{
				get
				{
					return 16843388;
				}
			}
			public static int gestureStrokeLengthThreshold
			{
				get
				{
					return 16843386;
				}
			}
			public static int gestureStrokeSquarenessThreshold
			{
				get
				{
					return 16843387;
				}
			}
			public static int gestureStrokeType
			{
				get
				{
					return 16843385;
				}
			}
			public static int gestureStrokeWidth
			{
				get
				{
					return 16843380;
				}
			}
			public static int glEsVersion
			{
				get
				{
					return 16843393;
				}
			}
			public static int gradientRadius
			{
				get
				{
					return 16843172;
				}
			}
			public static int grantUriPermissions
			{
				get
				{
					return 16842779;
				}
			}
			public static int gravity
			{
				get
				{
					return 16842927;
				}
			}
			public static int gridViewStyle
			{
				get
				{
					return 16842865;
				}
			}
			public static int groupIndicator
			{
				get
				{
					return 16843019;
				}
			}
			public static int hand_hour
			{
				get
				{
					return 16843011;
				}
			}
			public static int hand_minute
			{
				get
				{
					return 16843012;
				}
			}
			public static int handle
			{
				get
				{
					return 16843354;
				}
			}
			public static int handleProfiling
			{
				get
				{
					return 16842786;
				}
			}
			public static int hapticFeedbackEnabled
			{
				get
				{
					return 16843358;
				}
			}
			public static int hasCode
			{
				get
				{
					return 16842764;
				}
			}
			public static int headerBackground
			{
				get
				{
					return 16843055;
				}
			}
			public static int headerDividersEnabled
			{
				get
				{
					return 16843310;
				}
			}
			public static int height
			{
				get
				{
					return 16843093;
				}
			}
			public static int hint
			{
				get
				{
					return 16843088;
				}
			}
			public static int horizontalDivider
			{
				get
				{
					return 16843053;
				}
			}
			public static int horizontalGap
			{
				get
				{
					return 16843327;
				}
			}
			public static int horizontalSpacing
			{
				get
				{
					return 16843028;
				}
			}
			public static int host
			{
				get
				{
					return 16842792;
				}
			}
			public static int icon
			{
				get
				{
					return 16842754;
				}
			}
			public static int iconPreview
			{
				get
				{
					return 16843337;
				}
			}
			public static int id
			{
				get
				{
					return 16842960;
				}
			}
			public static int ignoreGravity
			{
				get
				{
					return 16843263;
				}
			}
			public static int imageButtonStyle
			{
				get
				{
					return 16842866;
				}
			}
			public static int imageWellStyle
			{
				get
				{
					return 16842867;
				}
			}
			public static int imeActionId
			{
				get
				{
					return 16843366;
				}
			}
			public static int imeActionLabel
			{
				get
				{
					return 16843365;
				}
			}
			public static int imeExtractEnterAnimation
			{
				get
				{
					return 16843368;
				}
			}
			public static int imeExtractExitAnimation
			{
				get
				{
					return 16843369;
				}
			}
			public static int imeFullscreenBackground
			{
				get
				{
					return 16843308;
				}
			}
			public static int imeOptions
			{
				get
				{
					return 16843364;
				}
			}
			public static int inAnimation
			{
				get
				{
					return 16843127;
				}
			}
			public static int includeFontPadding
			{
				get
				{
					return 16843103;
				}
			}
			public static int includeInGlobalSearch
			{
				get
				{
					return 16843374;
				}
			}
			public static int indeterminate
			{
				get
				{
					return 16843065;
				}
			}
			public static int indeterminateBehavior
			{
				get
				{
					return 16843070;
				}
			}
			public static int indeterminateDrawable
			{
				get
				{
					return 16843067;
				}
			}
			public static int indeterminateDuration
			{
				get
				{
					return 16843069;
				}
			}
			public static int indeterminateOnly
			{
				get
				{
					return 16843066;
				}
			}
			public static int indicatorLeft
			{
				get
				{
					return 16843021;
				}
			}
			public static int indicatorRight
			{
				get
				{
					return 16843022;
				}
			}
			public static int inflatedId
			{
				get
				{
					return 16842995;
				}
			}
			public static int initOrder
			{
				get
				{
					return 16842778;
				}
			}
			public static int initialLayout
			{
				get
				{
					return 16843345;
				}
			}
			public static int innerRadius
			{
				get
				{
					return 16843359;
				}
			}
			public static int innerRadiusRatio
			{
				get
				{
					return 16843163;
				}
			}
			public static int inputMethod
			{
				get
				{
					return 16843112;
				}
			}
			public static int inputType
			{
				get
				{
					return 16843296;
				}
			}
			public static int insetBottom
			{
				get
				{
					return 16843194;
				}
			}
			public static int insetLeft
			{
				get
				{
					return 16843191;
				}
			}
			public static int insetRight
			{
				get
				{
					return 16843192;
				}
			}
			public static int insetTop
			{
				get
				{
					return 16843193;
				}
			}
			public static int installLocation
			{
				get
				{
					return 16843447;
				}
			}
			public static int interpolator
			{
				get
				{
					return 16843073;
				}
			}
			public static int isDefault
			{
				get
				{
					return 16843297;
				}
			}
			public static int isIndicator
			{
				get
				{
					return 16843079;
				}
			}
			public static int isModifier
			{
				get
				{
					return 16843334;
				}
			}
			public static int isRepeatable
			{
				get
				{
					return 16843336;
				}
			}
			public static int isScrollContainer
			{
				get
				{
					return 16843342;
				}
			}
			public static int isSticky
			{
				get
				{
					return 16843335;
				}
			}
			public static int itemBackground
			{
				get
				{
					return 16843056;
				}
			}
			public static int itemIconDisabledAlpha
			{
				get
				{
					return 16843057;
				}
			}
			public static int itemTextAppearance
			{
				get
				{
					return 16843052;
				}
			}
			public static int keepScreenOn
			{
				get
				{
					return 16843286;
				}
			}
			public static int key
			{
				get
				{
					return 16843240;
				}
			}
			public static int keyBackground
			{
				get
				{
					return 16843315;
				}
			}
			public static int keyEdgeFlags
			{
				get
				{
					return 16843333;
				}
			}
			public static int keyHeight
			{
				get
				{
					return 16843326;
				}
			}
			public static int keyIcon
			{
				get
				{
					return 16843340;
				}
			}
			public static int keyLabel
			{
				get
				{
					return 16843339;
				}
			}
			public static int keyOutputText
			{
				get
				{
					return 16843338;
				}
			}
			public static int keyPreviewHeight
			{
				get
				{
					return 16843321;
				}
			}
			public static int keyPreviewLayout
			{
				get
				{
					return 16843319;
				}
			}
			public static int keyPreviewOffset
			{
				get
				{
					return 16843320;
				}
			}
			public static int keyTextColor
			{
				get
				{
					return 16843318;
				}
			}
			public static int keyTextSize
			{
				get
				{
					return 16843316;
				}
			}
			public static int keyWidth
			{
				get
				{
					return 16843325;
				}
			}
			public static int keyboardMode
			{
				get
				{
					return 16843341;
				}
			}
			public static int keycode
			{
				get
				{
					return 16842949;
				}
			}
			public static int killAfterRestore
			{
				get
				{
					return 16843420;
				}
			}
			public static int label
			{
				get
				{
					return 16842753;
				}
			}
			public static int labelTextSize
			{
				get
				{
					return 16843317;
				}
			}
			public static int largeScreens
			{
				get
				{
					return 16843398;
				}
			}
			public static int launchMode
			{
				get
				{
					return 16842781;
				}
			}
			public static int layout
			{
				get
				{
					return 16842994;
				}
			}
			public static int layoutAnimation
			{
				get
				{
					return 16842988;
				}
			}
			public static int layout_above
			{
				get
				{
					return 16843140;
				}
			}
			public static int layout_alignBaseline
			{
				get
				{
					return 16843142;
				}
			}
			public static int layout_alignBottom
			{
				get
				{
					return 16843146;
				}
			}
			public static int layout_alignLeft
			{
				get
				{
					return 16843143;
				}
			}
			public static int layout_alignParentBottom
			{
				get
				{
					return 16843150;
				}
			}
			public static int layout_alignParentLeft
			{
				get
				{
					return 16843147;
				}
			}
			public static int layout_alignParentRight
			{
				get
				{
					return 16843149;
				}
			}
			public static int layout_alignParentTop
			{
				get
				{
					return 16843148;
				}
			}
			public static int layout_alignRight
			{
				get
				{
					return 16843145;
				}
			}
			public static int layout_alignTop
			{
				get
				{
					return 16843144;
				}
			}
			public static int layout_alignWithParentIfMissing
			{
				get
				{
					return 16843154;
				}
			}
			public static int layout_below
			{
				get
				{
					return 16843141;
				}
			}
			public static int layout_centerHorizontal
			{
				get
				{
					return 16843152;
				}
			}
			public static int layout_centerInParent
			{
				get
				{
					return 16843151;
				}
			}
			public static int layout_centerVertical
			{
				get
				{
					return 16843153;
				}
			}
			public static int layout_column
			{
				get
				{
					return 16843084;
				}
			}
			public static int layout_gravity
			{
				get
				{
					return 16842931;
				}
			}
			public static int layout_height
			{
				get
				{
					return 16842997;
				}
			}
			public static int layout_margin
			{
				get
				{
					return 16842998;
				}
			}
			public static int layout_marginBottom
			{
				get
				{
					return 16843002;
				}
			}
			public static int layout_marginLeft
			{
				get
				{
					return 16842999;
				}
			}
			public static int layout_marginRight
			{
				get
				{
					return 16843001;
				}
			}
			public static int layout_marginTop
			{
				get
				{
					return 16843000;
				}
			}
			public static int layout_scale
			{
				get
				{
					return 16843155;
				}
			}
			public static int layout_span
			{
				get
				{
					return 16843085;
				}
			}
			public static int layout_toLeftOf
			{
				get
				{
					return 16843138;
				}
			}
			public static int layout_toRightOf
			{
				get
				{
					return 16843139;
				}
			}
			public static int layout_weight
			{
				get
				{
					return 16843137;
				}
			}
			public static int layout_width
			{
				get
				{
					return 16842996;
				}
			}
			public static int layout_x
			{
				get
				{
					return 16843135;
				}
			}
			public static int layout_y
			{
				get
				{
					return 16843136;
				}
			}
			public static int left
			{
				get
				{
					return 16843181;
				}
			}
			public static int lineSpacingExtra
			{
				get
				{
					return 16843287;
				}
			}
			public static int lineSpacingMultiplier
			{
				get
				{
					return 16843288;
				}
			}
			public static int lines
			{
				get
				{
					return 16843092;
				}
			}
			public static int linksClickable
			{
				get
				{
					return 16842929;
				}
			}
			public static int listChoiceIndicatorMultiple
			{
				get
				{
					return 16843290;
				}
			}
			public static int listChoiceIndicatorSingle
			{
				get
				{
					return 16843289;
				}
			}
			public static int listDivider
			{
				get
				{
					return 16843284;
				}
			}
			public static int listPreferredItemHeight
			{
				get
				{
					return 16842829;
				}
			}
			public static int listSelector
			{
				get
				{
					return 16843003;
				}
			}
			public static int listSeparatorTextViewStyle
			{
				get
				{
					return 16843272;
				}
			}
			public static int listViewStyle
			{
				get
				{
					return 16842868;
				}
			}
			public static int listViewWhiteStyle
			{
				get
				{
					return 16842869;
				}
			}
			public static int longClickable
			{
				get
				{
					return 16842982;
				}
			}
			public static int manageSpaceActivity
			{
				get
				{
					return 16842756;
				}
			}
			public static int mapViewStyle
			{
				get
				{
					return 16842890;
				}
			}
			public static int marqueeRepeatLimit
			{
				get
				{
					return 16843293;
				}
			}
			public static int max
			{
				get
				{
					return 16843062;
				}
			}
			public static int maxEms
			{
				get
				{
					return 16843095;
				}
			}
			public static int maxHeight
			{
				get
				{
					return 16843040;
				}
			}
			public static int maxItemsPerRow
			{
				get
				{
					return 16843060;
				}
			}
			public static int maxLength
			{
				get
				{
					return 16843104;
				}
			}
			public static int maxLevel
			{
				get
				{
					return 16843186;
				}
			}
			public static int maxLines
			{
				get
				{
					return 16843091;
				}
			}
			public static int maxRows
			{
				get
				{
					return 16843059;
				}
			}
			public static int maxSdkVersion
			{
				get
				{
					return 16843377;
				}
			}
			public static int maxWidth
			{
				get
				{
					return 16843039;
				}
			}
			public static int measureAllChildren
			{
				get
				{
					return 16843018;
				}
			}
			public static int menuCategory
			{
				get
				{
					return 16843230;
				}
			}
			public static int mimeType
			{
				get
				{
					return 16842790;
				}
			}
			public static int minEms
			{
				get
				{
					return 16843098;
				}
			}
			public static int minHeight
			{
				get
				{
					return 16843072;
				}
			}
			public static int minLevel
			{
				get
				{
					return 16843185;
				}
			}
			public static int minLines
			{
				get
				{
					return 16843094;
				}
			}
			public static int minSdkVersion
			{
				get
				{
					return 16843276;
				}
			}
			public static int minWidth
			{
				get
				{
					return 16843071;
				}
			}
			public static int mode
			{
				get
				{
					return 16843134;
				}
			}
			public static int moreIcon
			{
				get
				{
					return 16843061;
				}
			}
			public static int multiprocess
			{
				get
				{
					return 16842771;
				}
			}
			public static int name
			{
				get
				{
					return 16842755;
				}
			}
			public static int negativeButtonText
			{
				get
				{
					return 16843254;
				}
			}
			public static int nextFocusDown
			{
				get
				{
					return 16842980;
				}
			}
			public static int nextFocusLeft
			{
				get
				{
					return 16842977;
				}
			}
			public static int nextFocusRight
			{
				get
				{
					return 16842978;
				}
			}
			public static int nextFocusUp
			{
				get
				{
					return 16842979;
				}
			}
			public static int noHistory
			{
				get
				{
					return 16843309;
				}
			}
			public static int normalScreens
			{
				get
				{
					return 16843397;
				}
			}
			public static int numColumns
			{
				get
				{
					return 16843032;
				}
			}
			public static int numStars
			{
				get
				{
					return 16843076;
				}
			}
			public static int numeric
			{
				get
				{
					return 16843109;
				}
			}
			public static int numericShortcut
			{
				get
				{
					return 16843236;
				}
			}
			public static int onClick
			{
				get
				{
					return 16843375;
				}
			}
			public static int oneshot
			{
				get
				{
					return 16843159;
				}
			}
			public static int order
			{
				get
				{
					return 16843242;
				}
			}
			public static int orderInCategory
			{
				get
				{
					return 16843231;
				}
			}
			public static int orderingFromXml
			{
				get
				{
					return 16843239;
				}
			}
			public static int orientation
			{
				get
				{
					return 16842948;
				}
			}
			public static int outAnimation
			{
				get
				{
					return 16843128;
				}
			}
			public static int padding
			{
				get
				{
					return 16842965;
				}
			}
			public static int paddingBottom
			{
				get
				{
					return 16842969;
				}
			}
			public static int paddingLeft
			{
				get
				{
					return 16842966;
				}
			}
			public static int paddingRight
			{
				get
				{
					return 16842968;
				}
			}
			public static int paddingTop
			{
				get
				{
					return 16842967;
				}
			}
			public static int panelBackground
			{
				get
				{
					return 16842846;
				}
			}
			public static int panelColorBackground
			{
				get
				{
					return 16842849;
				}
			}
			public static int panelColorForeground
			{
				get
				{
					return 16842848;
				}
			}
			public static int panelFullBackground
			{
				get
				{
					return 16842847;
				}
			}
			public static int panelTextAppearance
			{
				get
				{
					return 16842850;
				}
			}
			public static int password
			{
				get
				{
					return 16843100;
				}
			}
			public static int path
			{
				get
				{
					return 16842794;
				}
			}
			public static int pathPattern
			{
				get
				{
					return 16842796;
				}
			}
			public static int pathPrefix
			{
				get
				{
					return 16842795;
				}
			}
			public static int permission
			{
				get
				{
					return 16842758;
				}
			}
			public static int permissionGroup
			{
				get
				{
					return 16842762;
				}
			}
			public static int persistent
			{
				get
				{
					return 16842765;
				}
			}
			public static int persistentDrawingCache
			{
				get
				{
					return 16842990;
				}
			}
			public static int phoneNumber
			{
				get
				{
					return 16843111;
				}
			}
			public static int pivotX
			{
				get
				{
					return 16843189;
				}
			}
			public static int pivotY
			{
				get
				{
					return 16843190;
				}
			}
			public static int popupBackground
			{
				get
				{
					return 16843126;
				}
			}
			public static int popupCharacters
			{
				get
				{
					return 16843332;
				}
			}
			public static int popupKeyboard
			{
				get
				{
					return 16843331;
				}
			}
			public static int popupLayout
			{
				get
				{
					return 16843323;
				}
			}
			public static int popupWindowStyle
			{
				get
				{
					return 16842870;
				}
			}
			public static int port
			{
				get
				{
					return 16842793;
				}
			}
			public static int positiveButtonText
			{
				get
				{
					return 16843253;
				}
			}
			public static int preferenceCategoryStyle
			{
				get
				{
					return 16842892;
				}
			}
			public static int preferenceInformationStyle
			{
				get
				{
					return 16842893;
				}
			}
			public static int preferenceLayoutChild
			{
				get
				{
					return 16842900;
				}
			}
			public static int preferenceScreenStyle
			{
				get
				{
					return 16842891;
				}
			}
			public static int preferenceStyle
			{
				get
				{
					return 16842894;
				}
			}
			public static int priority
			{
				get
				{
					return 16842780;
				}
			}
			public static int privateImeOptions
			{
				get
				{
					return 16843299;
				}
			}
			public static int process
			{
				get
				{
					return 16842769;
				}
			}
			public static int progress
			{
				get
				{
					return 16843063;
				}
			}
			public static int progressBarStyle
			{
				get
				{
					return 16842871;
				}
			}
			public static int progressBarStyleHorizontal
			{
				get
				{
					return 16842872;
				}
			}
			public static int progressBarStyleInverse
			{
				get
				{
					return 16843399;
				}
			}
			public static int progressBarStyleLarge
			{
				get
				{
					return 16842874;
				}
			}
			public static int progressBarStyleLargeInverse
			{
				get
				{
					return 16843401;
				}
			}
			public static int progressBarStyleSmall
			{
				get
				{
					return 16842873;
				}
			}
			public static int progressBarStyleSmallInverse
			{
				get
				{
					return 16843400;
				}
			}
			public static int progressBarStyleSmallTitle
			{
				get
				{
					return 16843279;
				}
			}
			public static int progressDrawable
			{
				get
				{
					return 16843068;
				}
			}
			public static int prompt
			{
				get
				{
					return 16843131;
				}
			}
			public static int protectionLevel
			{
				get
				{
					return 16842761;
				}
			}
			public static int queryActionMsg
			{
				get
				{
					return 16843227;
				}
			}
			public static int queryAfterZeroResults
			{
				get
				{
					return 16843394;
				}
			}
			public static int quickContactBadgeStyleSmallWindowLarge
			{
				get
				{
					return 16843443;
				}
			}
			public static int quickContactBadgeStyleSmallWindowMedium
			{
				get
				{
					return 16843442;
				}
			}
			public static int quickContactBadgeStyleSmallWindowSmall
			{
				get
				{
					return 16843441;
				}
			}
			public static int quickContactBadgeStyleWindowLarge
			{
				get
				{
					return 16843440;
				}
			}
			public static int quickContactBadgeStyleWindowMedium
			{
				get
				{
					return 16843439;
				}
			}
			public static int quickContactBadgeStyleWindowSmall
			{
				get
				{
					return 16843438;
				}
			}
			public static int radioButtonStyle
			{
				get
				{
					return 16842878;
				}
			}
			public static int radius
			{
				get
				{
					return 16843176;
				}
			}
			public static int rating
			{
				get
				{
					return 16843077;
				}
			}
			public static int ratingBarStyle
			{
				get
				{
					return 16842876;
				}
			}
			public static int ratingBarStyleIndicator
			{
				get
				{
					return 16843280;
				}
			}
			public static int ratingBarStyleSmall
			{
				get
				{
					return 16842877;
				}
			}
			public static int readPermission
			{
				get
				{
					return 16842759;
				}
			}
			public static int repeatCount
			{
				get
				{
					return 16843199;
				}
			}
			public static int repeatMode
			{
				get
				{
					return 16843200;
				}
			}
			public static int reqFiveWayNav
			{
				get
				{
					return 16843314;
				}
			}
			public static int reqHardKeyboard
			{
				get
				{
					return 16843305;
				}
			}
			public static int reqKeyboardType
			{
				get
				{
					return 16843304;
				}
			}
			public static int reqNavigation
			{
				get
				{
					return 16843306;
				}
			}
			public static int reqTouchScreen
			{
				get
				{
					return 16843303;
				}
			}
			public static int required
			{
				get
				{
					return 16843406;
				}
			}
			public static int resizeable
			{
				get
				{
					return 16843405;
				}
			}
			public static int resource
			{
				get
				{
					return 16842789;
				}
			}
			public static int restoreAnyVersion
			{
				get
				{
					return 16843450;
				}
			}
			public static int restoreNeedsApplication
			{
				get
				{
					return 16843421;
				}
			}
			public static int right
			{
				get
				{
					return 16843183;
				}
			}
			public static int ringtonePreferenceStyle
			{
				get
				{
					return 16842899;
				}
			}
			public static int ringtoneType
			{
				get
				{
					return 16843257;
				}
			}
			public static int rowDelay
			{
				get
				{
					return 16843216;
				}
			}
			public static int rowEdgeFlags
			{
				get
				{
					return 16843329;
				}
			}
			public static int rowHeight
			{
				get
				{
					return 16843058;
				}
			}
			public static int saveEnabled
			{
				get
				{
					return 16842983;
				}
			}
			public static int scaleGravity
			{
				get
				{
					return 16843262;
				}
			}
			public static int scaleHeight
			{
				get
				{
					return 16843261;
				}
			}
			public static int scaleType
			{
				get
				{
					return 16843037;
				}
			}
			public static int scaleWidth
			{
				get
				{
					return 16843260;
				}
			}
			public static int scheme
			{
				get
				{
					return 16842791;
				}
			}
			public static int screenOrientation
			{
				get
				{
					return 16842782;
				}
			}
			public static int scrollHorizontally
			{
				get
				{
					return 16843099;
				}
			}
			public static int scrollViewStyle
			{
				get
				{
					return 16842880;
				}
			}
			public static int scrollX
			{
				get
				{
					return 16842962;
				}
			}
			public static int scrollY
			{
				get
				{
					return 16842963;
				}
			}
			public static int scrollbarAlwaysDrawHorizontalTrack
			{
				get
				{
					return 16842856;
				}
			}
			public static int scrollbarAlwaysDrawVerticalTrack
			{
				get
				{
					return 16842857;
				}
			}
			public static int scrollbarDefaultDelayBeforeFade
			{
				get
				{
					return 16843433;
				}
			}
			public static int scrollbarFadeDuration
			{
				get
				{
					return 16843432;
				}
			}
			public static int scrollbarSize
			{
				get
				{
					return 16842851;
				}
			}
			public static int scrollbarStyle
			{
				get
				{
					return 16842879;
				}
			}
			public static int scrollbarThumbHorizontal
			{
				get
				{
					return 16842852;
				}
			}
			public static int scrollbarThumbVertical
			{
				get
				{
					return 16842853;
				}
			}
			public static int scrollbarTrackHorizontal
			{
				get
				{
					return 16842854;
				}
			}
			public static int scrollbarTrackVertical
			{
				get
				{
					return 16842855;
				}
			}
			public static int scrollbars
			{
				get
				{
					return 16842974;
				}
			}
			public static int scrollingCache
			{
				get
				{
					return 16843006;
				}
			}
			public static int searchButtonText
			{
				get
				{
					return 16843269;
				}
			}
			public static int searchMode
			{
				get
				{
					return 16843221;
				}
			}
			public static int searchSettingsDescription
			{
				get
				{
					return 16843402;
				}
			}
			public static int searchSuggestAuthority
			{
				get
				{
					return 16843222;
				}
			}
			public static int searchSuggestIntentAction
			{
				get
				{
					return 16843225;
				}
			}
			public static int searchSuggestIntentData
			{
				get
				{
					return 16843226;
				}
			}
			public static int searchSuggestPath
			{
				get
				{
					return 16843223;
				}
			}
			public static int searchSuggestSelection
			{
				get
				{
					return 16843224;
				}
			}
			public static int searchSuggestThreshold
			{
				get
				{
					return 16843373;
				}
			}
			public static int secondaryProgress
			{
				get
				{
					return 16843064;
				}
			}
			public static int seekBarStyle
			{
				get
				{
					return 16842875;
				}
			}
			public static int selectAllOnFocus
			{
				get
				{
					return 16843102;
				}
			}
			public static int selectable
			{
				get
				{
					return 16843238;
				}
			}
			public static int settingsActivity
			{
				get
				{
					return 16843301;
				}
			}
			public static int shadowColor
			{
				get
				{
					return 16843105;
				}
			}
			public static int shadowDx
			{
				get
				{
					return 16843106;
				}
			}
			public static int shadowDy
			{
				get
				{
					return 16843107;
				}
			}
			public static int shadowRadius
			{
				get
				{
					return 16843108;
				}
			}
			public static int shape
			{
				get
				{
					return 16843162;
				}
			}
			public static int shareInterpolator
			{
				get
				{
					return 16843195;
				}
			}
			public static int sharedUserId
			{
				get
				{
					return 16842763;
				}
			}
			public static int sharedUserLabel
			{
				get
				{
					return 16843361;
				}
			}
			public static int shouldDisableView
			{
				get
				{
					return 16843246;
				}
			}
			public static int showDefault
			{
				get
				{
					return 16843258;
				}
			}
			public static int showSilent
			{
				get
				{
					return 16843259;
				}
			}
			public static int shrinkColumns
			{
				get
				{
					return 16843082;
				}
			}
			public static int singleLine
			{
				get
				{
					return 16843101;
				}
			}
			public static int smallIcon
			{
				get
				{
					return 16843422;
				}
			}
			public static int smallScreens
			{
				get
				{
					return 16843396;
				}
			}
			public static int smoothScrollbar
			{
				get
				{
					return 16843313;
				}
			}
			public static int soundEffectsEnabled
			{
				get
				{
					return 16843285;
				}
			}
			public static int spacing
			{
				get
				{
					return 16843027;
				}
			}
			public static int spinnerDropDownItemStyle
			{
				get
				{
					return 16842887;
				}
			}
			public static int spinnerItemStyle
			{
				get
				{
					return 16842889;
				}
			}
			public static int spinnerStyle
			{
				get
				{
					return 16842881;
				}
			}
			public static int src
			{
				get
				{
					return 16843033;
				}
			}
			public static int stackFromBottom
			{
				get
				{
					return 16843005;
				}
			}
			public static int starStyle
			{
				get
				{
					return 16842882;
				}
			}
			public static int startColor
			{
				get
				{
					return 16843165;
				}
			}
			public static int startOffset
			{
				get
				{
					return 16843198;
				}
			}
			public static int startYear
			{
				get
				{
					return 16843132;
				}
			}
			public static int stateNotNeeded
			{
				get
				{
					return 16842774;
				}
			}
			public static int state_above_anchor
			{
				get
				{
					return 16842922;
				}
			}
			public static int state_active
			{
				get
				{
					return 16842914;
				}
			}
			public static int state_checkable
			{
				get
				{
					return 16842911;
				}
			}
			public static int state_checked
			{
				get
				{
					return 16842912;
				}
			}
			public static int state_empty
			{
				get
				{
					return 16842921;
				}
			}
			public static int state_enabled
			{
				get
				{
					return 16842910;
				}
			}
			public static int state_expanded
			{
				get
				{
					return 16842920;
				}
			}
			public static int state_first
			{
				get
				{
					return 16842916;
				}
			}
			public static int state_focused
			{
				get
				{
					return 16842908;
				}
			}
			public static int state_last
			{
				get
				{
					return 16842918;
				}
			}
			public static int state_long_pressable
			{
				get
				{
					return 16843324;
				}
			}
			public static int state_middle
			{
				get
				{
					return 16842917;
				}
			}
			public static int state_pressed
			{
				get
				{
					return 16842919;
				}
			}
			public static int state_selected
			{
				get
				{
					return 16842913;
				}
			}
			public static int state_single
			{
				get
				{
					return 16842915;
				}
			}
			public static int state_window_focused
			{
				get
				{
					return 16842909;
				}
			}
			public static int stepSize
			{
				get
				{
					return 16843078;
				}
			}
			public static int streamType
			{
				get
				{
					return 16843273;
				}
			}
			public static int stretchColumns
			{
				get
				{
					return 16843081;
				}
			}
			public static int stretchMode
			{
				get
				{
					return 16843030;
				}
			}
			public static int suggestActionMsg
			{
				get
				{
					return 16843228;
				}
			}
			public static int suggestActionMsgColumn
			{
				get
				{
					return 16843229;
				}
			}
			public static int summary
			{
				get
				{
					return 16843241;
				}
			}
			public static int summaryColumn
			{
				get
				{
					return 16843426;
				}
			}
			public static int summaryOff
			{
				get
				{
					return 16843248;
				}
			}
			public static int summaryOn
			{
				get
				{
					return 16843247;
				}
			}
			public static int supportsUploading
			{
				get
				{
					return 16843419;
				}
			}
			public static int syncable
			{
				get
				{
					return 16842777;
				}
			}
			public static int tabStripEnabled
			{
				get
				{
					return 16843453;
				}
			}
			public static int tabStripLeft
			{
				get
				{
					return 16843451;
				}
			}
			public static int tabStripRight
			{
				get
				{
					return 16843452;
				}
			}
			public static int tabWidgetStyle
			{
				get
				{
					return 16842883;
				}
			}
			public static int tag
			{
				get
				{
					return 16842961;
				}
			}
			public static int targetActivity
			{
				get
				{
					return 16843266;
				}
			}
			public static int targetClass
			{
				get
				{
					return 16842799;
				}
			}
			public static int targetPackage
			{
				get
				{
					return 16842785;
				}
			}
			public static int targetSdkVersion
			{
				get
				{
					return 16843376;
				}
			}
			public static int taskAffinity
			{
				get
				{
					return 16842770;
				}
			}
			public static int taskCloseEnterAnimation
			{
				get
				{
					return 16842942;
				}
			}
			public static int taskCloseExitAnimation
			{
				get
				{
					return 16842943;
				}
			}
			public static int taskOpenEnterAnimation
			{
				get
				{
					return 16842940;
				}
			}
			public static int taskOpenExitAnimation
			{
				get
				{
					return 16842941;
				}
			}
			public static int taskToBackEnterAnimation
			{
				get
				{
					return 16842946;
				}
			}
			public static int taskToBackExitAnimation
			{
				get
				{
					return 16842947;
				}
			}
			public static int taskToFrontEnterAnimation
			{
				get
				{
					return 16842944;
				}
			}
			public static int taskToFrontExitAnimation
			{
				get
				{
					return 16842945;
				}
			}
			public static int tension
			{
				get
				{
					return 16843370;
				}
			}
			public static int testOnly
			{
				get
				{
					return 16843378;
				}
			}
			public static int text
			{
				get
				{
					return 16843087;
				}
			}
			public static int textAppearance
			{
				get
				{
					return 16842804;
				}
			}
			public static int textAppearanceButton
			{
				get
				{
					return 16843271;
				}
			}
			public static int textAppearanceInverse
			{
				get
				{
					return 16842805;
				}
			}
			public static int textAppearanceLarge
			{
				get
				{
					return 16842816;
				}
			}
			public static int textAppearanceLargeInverse
			{
				get
				{
					return 16842819;
				}
			}
			public static int textAppearanceMedium
			{
				get
				{
					return 16842817;
				}
			}
			public static int textAppearanceMediumInverse
			{
				get
				{
					return 16842820;
				}
			}
			public static int textAppearanceSearchResultSubtitle
			{
				get
				{
					return 16843424;
				}
			}
			public static int textAppearanceSearchResultTitle
			{
				get
				{
					return 16843425;
				}
			}
			public static int textAppearanceSmall
			{
				get
				{
					return 16842818;
				}
			}
			public static int textAppearanceSmallInverse
			{
				get
				{
					return 16842821;
				}
			}
			public static int textCheckMark
			{
				get
				{
					return 16842822;
				}
			}
			public static int textCheckMarkInverse
			{
				get
				{
					return 16842823;
				}
			}
			public static int textColor
			{
				get
				{
					return 16842904;
				}
			}
			public static int textColorHighlight
			{
				get
				{
					return 16842905;
				}
			}
			public static int textColorHint
			{
				get
				{
					return 16842906;
				}
			}
			public static int textColorHintInverse
			{
				get
				{
					return 16842815;
				}
			}
			public static int textColorLink
			{
				get
				{
					return 16842907;
				}
			}
			public static int textColorPrimary
			{
				get
				{
					return 16842806;
				}
			}
			public static int textColorPrimaryDisableOnly
			{
				get
				{
					return 16842807;
				}
			}
			public static int textColorPrimaryInverse
			{
				get
				{
					return 16842809;
				}
			}
			public static int textColorPrimaryInverseDisableOnly
			{
				get
				{
					return 16843403;
				}
			}
			public static int textColorPrimaryInverseNoDisable
			{
				get
				{
					return 16842813;
				}
			}
			public static int textColorPrimaryNoDisable
			{
				get
				{
					return 16842811;
				}
			}
			public static int textColorSecondary
			{
				get
				{
					return 16842808;
				}
			}
			public static int textColorSecondaryInverse
			{
				get
				{
					return 16842810;
				}
			}
			public static int textColorSecondaryInverseNoDisable
			{
				get
				{
					return 16842814;
				}
			}
			public static int textColorSecondaryNoDisable
			{
				get
				{
					return 16842812;
				}
			}
			public static int textColorTertiary
			{
				get
				{
					return 16843282;
				}
			}
			public static int textColorTertiaryInverse
			{
				get
				{
					return 16843283;
				}
			}
			public static int textFilterEnabled
			{
				get
				{
					return 16843007;
				}
			}
			public static int textOff
			{
				get
				{
					return 16843045;
				}
			}
			public static int textOn
			{
				get
				{
					return 16843044;
				}
			}
			public static int textScaleX
			{
				get
				{
					return 16843089;
				}
			}
			public static int textSize
			{
				get
				{
					return 16842901;
				}
			}
			public static int textStyle
			{
				get
				{
					return 16842903;
				}
			}
			public static int textViewStyle
			{
				get
				{
					return 16842884;
				}
			}
			public static int theme
			{
				get
				{
					return 16842752;
				}
			}
			public static int thickness
			{
				get
				{
					return 16843360;
				}
			}
			public static int thicknessRatio
			{
				get
				{
					return 16843164;
				}
			}
			public static int thumb
			{
				get
				{
					return 16843074;
				}
			}
			public static int thumbOffset
			{
				get
				{
					return 16843075;
				}
			}
			public static int thumbnail
			{
				get
				{
					return 16843429;
				}
			}
			public static int tileMode
			{
				get
				{
					return 16843265;
				}
			}
			public static int tint
			{
				get
				{
					return 16843041;
				}
			}
			public static int title
			{
				get
				{
					return 16843233;
				}
			}
			public static int titleCondensed
			{
				get
				{
					return 16843234;
				}
			}
			public static int toAlpha
			{
				get
				{
					return 16843211;
				}
			}
			public static int toDegrees
			{
				get
				{
					return 16843188;
				}
			}
			public static int toXDelta
			{
				get
				{
					return 16843207;
				}
			}
			public static int toXScale
			{
				get
				{
					return 16843203;
				}
			}
			public static int toYDelta
			{
				get
				{
					return 16843209;
				}
			}
			public static int toYScale
			{
				get
				{
					return 16843205;
				}
			}
			public static int top
			{
				get
				{
					return 16843182;
				}
			}
			public static int topBright
			{
				get
				{
					return 16842955;
				}
			}
			public static int topDark
			{
				get
				{
					return 16842951;
				}
			}
			public static int topLeftRadius
			{
				get
				{
					return 16843177;
				}
			}
			public static int topOffset
			{
				get
				{
					return 16843352;
				}
			}
			public static int topRightRadius
			{
				get
				{
					return 16843178;
				}
			}
			public static int transcriptMode
			{
				get
				{
					return 16843008;
				}
			}
			public static int type
			{
				get
				{
					return 16843169;
				}
			}
			public static int typeface
			{
				get
				{
					return 16842902;
				}
			}
			public static int uncertainGestureColor
			{
				get
				{
					return 16843382;
				}
			}
			public static int unselectedAlpha
			{
				get
				{
					return 16843278;
				}
			}
			public static int updatePeriodMillis
			{
				get
				{
					return 16843344;
				}
			}
			public static int useLevel
			{
				get
				{
					return 16843167;
				}
			}
			public static int userVisible
			{
				get
				{
					return 16843409;
				}
			}
			public static int value
			{
				get
				{
					return 16842788;
				}
			}
			public static int variablePadding
			{
				get
				{
					return 16843157;
				}
			}
			public static int versionCode
			{
				get
				{
					return 16843291;
				}
			}
			public static int versionName
			{
				get
				{
					return 16843292;
				}
			}
			public static int verticalCorrection
			{
				get
				{
					return 16843322;
				}
			}
			public static int verticalDivider
			{
				get
				{
					return 16843054;
				}
			}
			public static int verticalGap
			{
				get
				{
					return 16843328;
				}
			}
			public static int verticalSpacing
			{
				get
				{
					return 16843029;
				}
			}
			public static int visibility
			{
				get
				{
					return 16842972;
				}
			}
			public static int visible
			{
				get
				{
					return 16843156;
				}
			}
			public static int vmSafeMode
			{
				get
				{
					return 16843448;
				}
			}
			public static int voiceLanguage
			{
				get
				{
					return 16843349;
				}
			}
			public static int voiceLanguageModel
			{
				get
				{
					return 16843347;
				}
			}
			public static int voiceMaxResults
			{
				get
				{
					return 16843350;
				}
			}
			public static int voicePromptText
			{
				get
				{
					return 16843348;
				}
			}
			public static int voiceSearchMode
			{
				get
				{
					return 16843346;
				}
			}
			public static int wallpaperCloseEnterAnimation
			{
				get
				{
					return 16843413;
				}
			}
			public static int wallpaperCloseExitAnimation
			{
				get
				{
					return 16843414;
				}
			}
			public static int wallpaperIntraCloseEnterAnimation
			{
				get
				{
					return 16843417;
				}
			}
			public static int wallpaperIntraCloseExitAnimation
			{
				get
				{
					return 16843418;
				}
			}
			public static int wallpaperIntraOpenEnterAnimation
			{
				get
				{
					return 16843415;
				}
			}
			public static int wallpaperIntraOpenExitAnimation
			{
				get
				{
					return 16843416;
				}
			}
			public static int wallpaperOpenEnterAnimation
			{
				get
				{
					return 16843411;
				}
			}
			public static int wallpaperOpenExitAnimation
			{
				get
				{
					return 16843412;
				}
			}
			public static int webTextViewStyle
			{
				get
				{
					return 16843449;
				}
			}
			public static int webViewStyle
			{
				get
				{
					return 16842885;
				}
			}
			public static int weightSum
			{
				get
				{
					return 16843048;
				}
			}
			public static int widgetLayout
			{
				get
				{
					return 16843243;
				}
			}
			public static int width
			{
				get
				{
					return 16843097;
				}
			}
			public static int windowAnimationStyle
			{
				get
				{
					return 16842926;
				}
			}
			public static int windowBackground
			{
				get
				{
					return 16842836;
				}
			}
			public static int windowContentOverlay
			{
				get
				{
					return 16842841;
				}
			}
			public static int windowDisablePreview
			{
				get
				{
					return 16843298;
				}
			}
			public static int windowEnterAnimation
			{
				get
				{
					return 16842932;
				}
			}
			public static int windowExitAnimation
			{
				get
				{
					return 16842933;
				}
			}
			public static int windowFrame
			{
				get
				{
					return 16842837;
				}
			}
			public static int windowFullscreen
			{
				get
				{
					return 16843277;
				}
			}
			public static int windowHideAnimation
			{
				get
				{
					return 16842935;
				}
			}
			public static int windowIsFloating
			{
				get
				{
					return 16842839;
				}
			}
			public static int windowIsTranslucent
			{
				get
				{
					return 16842840;
				}
			}
			public static int windowNoDisplay
			{
				get
				{
					return 16843294;
				}
			}
			public static int windowNoTitle
			{
				get
				{
					return 16842838;
				}
			}
			public static int windowShowAnimation
			{
				get
				{
					return 16842934;
				}
			}
			public static int windowShowWallpaper
			{
				get
				{
					return 16843410;
				}
			}
			public static int windowSoftInputMode
			{
				get
				{
					return 16843307;
				}
			}
			public static int windowTitleBackgroundStyle
			{
				get
				{
					return 16842844;
				}
			}
			public static int windowTitleSize
			{
				get
				{
					return 16842842;
				}
			}
			public static int windowTitleStyle
			{
				get
				{
					return 16842843;
				}
			}
			public static int writePermission
			{
				get
				{
					return 16842760;
				}
			}
			public static int x
			{
				get
				{
					return 16842924;
				}
			}
			public static int y
			{
				get
				{
					return 16842925;
				}
			}
			public static int yesNoPreferenceStyle
			{
				get
				{
					return 16842896;
				}
			}
			public static int zAdjustment
			{
				get
				{
					return 16843201;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.R.attr.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/R$attr"));
				global::android.R.attr._attr5 = @__env.GetMethodIDNoThrow(global::android.R.attr.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class @bool : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static @bool()
			{
				InitJNI();
			}
			internal @bool(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _bool6;
			public @bool()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.R.@bool.staticClass, global::android.R.@bool._bool6);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.R.@bool.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/R$@bool"));
				global::android.R.@bool._bool6 = @__env.GetMethodIDNoThrow(global::android.R.@bool.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class color : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static color()
			{
				InitJNI();
			}
			internal color(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _color7;
			public color()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.R.color.staticClass, global::android.R.color._color7);
				Init(@__env, handle);
			}
			public static int background_dark
			{
				get
				{
					return 17170446;
				}
			}
			public static int background_light
			{
				get
				{
					return 17170447;
				}
			}
			public static int black
			{
				get
				{
					return 17170444;
				}
			}
			public static int darker_gray
			{
				get
				{
					return 17170432;
				}
			}
			public static int primary_text_dark
			{
				get
				{
					return 17170433;
				}
			}
			public static int primary_text_dark_nodisable
			{
				get
				{
					return 17170434;
				}
			}
			public static int primary_text_light
			{
				get
				{
					return 17170435;
				}
			}
			public static int primary_text_light_nodisable
			{
				get
				{
					return 17170436;
				}
			}
			public static int secondary_text_dark
			{
				get
				{
					return 17170437;
				}
			}
			public static int secondary_text_dark_nodisable
			{
				get
				{
					return 17170438;
				}
			}
			public static int secondary_text_light
			{
				get
				{
					return 17170439;
				}
			}
			public static int secondary_text_light_nodisable
			{
				get
				{
					return 17170440;
				}
			}
			public static int tab_indicator_text
			{
				get
				{
					return 17170441;
				}
			}
			public static int tertiary_text_dark
			{
				get
				{
					return 17170448;
				}
			}
			public static int tertiary_text_light
			{
				get
				{
					return 17170449;
				}
			}
			public static int transparent
			{
				get
				{
					return 17170445;
				}
			}
			public static int white
			{
				get
				{
					return 17170443;
				}
			}
			public static int widget_edittext_dark
			{
				get
				{
					return 17170442;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.R.color.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/R$color"));
				global::android.R.color._color7 = @__env.GetMethodIDNoThrow(global::android.R.color.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class dimen : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static dimen()
			{
				InitJNI();
			}
			internal dimen(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _dimen8;
			public dimen()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.R.dimen.staticClass, global::android.R.dimen._dimen8);
				Init(@__env, handle);
			}
			public static int app_icon_size
			{
				get
				{
					return 17104896;
				}
			}
			public static int thumbnail_height
			{
				get
				{
					return 17104897;
				}
			}
			public static int thumbnail_width
			{
				get
				{
					return 17104898;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.R.dimen.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/R$dimen"));
				global::android.R.dimen._dimen8 = @__env.GetMethodIDNoThrow(global::android.R.dimen.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class drawable : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static drawable()
			{
				InitJNI();
			}
			internal drawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _drawable9;
			public drawable()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.R.drawable.staticClass, global::android.R.drawable._drawable9);
				Init(@__env, handle);
			}
			public static int alert_dark_frame
			{
				get
				{
					return 17301504;
				}
			}
			public static int alert_light_frame
			{
				get
				{
					return 17301505;
				}
			}
			public static int arrow_down_float
			{
				get
				{
					return 17301506;
				}
			}
			public static int arrow_up_float
			{
				get
				{
					return 17301507;
				}
			}
			public static int bottom_bar
			{
				get
				{
					return 17301658;
				}
			}
			public static int btn_default
			{
				get
				{
					return 17301508;
				}
			}
			public static int btn_default_small
			{
				get
				{
					return 17301509;
				}
			}
			public static int btn_dialog
			{
				get
				{
					return 17301527;
				}
			}
			public static int btn_dropdown
			{
				get
				{
					return 17301510;
				}
			}
			public static int btn_minus
			{
				get
				{
					return 17301511;
				}
			}
			public static int btn_plus
			{
				get
				{
					return 17301512;
				}
			}
			public static int btn_radio
			{
				get
				{
					return 17301513;
				}
			}
			public static int btn_star
			{
				get
				{
					return 17301514;
				}
			}
			public static int btn_star_big_off
			{
				get
				{
					return 17301515;
				}
			}
			public static int btn_star_big_on
			{
				get
				{
					return 17301516;
				}
			}
			public static int button_onoff_indicator_off
			{
				get
				{
					return 17301518;
				}
			}
			public static int button_onoff_indicator_on
			{
				get
				{
					return 17301517;
				}
			}
			public static int checkbox_off_background
			{
				get
				{
					return 17301519;
				}
			}
			public static int checkbox_on_background
			{
				get
				{
					return 17301520;
				}
			}
			public static int dark_header
			{
				get
				{
					return 17301669;
				}
			}
			public static int dialog_frame
			{
				get
				{
					return 17301521;
				}
			}
			public static int divider_horizontal_bright
			{
				get
				{
					return 17301522;
				}
			}
			public static int divider_horizontal_dark
			{
				get
				{
					return 17301524;
				}
			}
			public static int divider_horizontal_dim_dark
			{
				get
				{
					return 17301525;
				}
			}
			public static int divider_horizontal_textfield
			{
				get
				{
					return 17301523;
				}
			}
			public static int edit_text
			{
				get
				{
					return 17301526;
				}
			}
			public static int editbox_background
			{
				get
				{
					return 17301528;
				}
			}
			public static int editbox_background_normal
			{
				get
				{
					return 17301529;
				}
			}
			public static int editbox_dropdown_dark_frame
			{
				get
				{
					return 17301530;
				}
			}
			public static int editbox_dropdown_light_frame
			{
				get
				{
					return 17301531;
				}
			}
			public static int gallery_thumb
			{
				get
				{
					return 17301532;
				}
			}
			public static int ic_btn_speak_now
			{
				get
				{
					return 17301668;
				}
			}
			public static int ic_delete
			{
				get
				{
					return 17301533;
				}
			}
			public static int ic_dialog_alert
			{
				get
				{
					return 17301543;
				}
			}
			public static int ic_dialog_dialer
			{
				get
				{
					return 17301544;
				}
			}
			public static int ic_dialog_email
			{
				get
				{
					return 17301545;
				}
			}
			public static int ic_dialog_info
			{
				get
				{
					return 17301659;
				}
			}
			public static int ic_dialog_map
			{
				get
				{
					return 17301546;
				}
			}
			public static int ic_input_add
			{
				get
				{
					return 17301547;
				}
			}
			public static int ic_input_delete
			{
				get
				{
					return 17301548;
				}
			}
			public static int ic_input_get
			{
				get
				{
					return 17301549;
				}
			}
			public static int ic_lock_idle_alarm
			{
				get
				{
					return 17301550;
				}
			}
			public static int ic_lock_idle_charging
			{
				get
				{
					return 17301534;
				}
			}
			public static int ic_lock_idle_lock
			{
				get
				{
					return 17301535;
				}
			}
			public static int ic_lock_idle_low_battery
			{
				get
				{
					return 17301536;
				}
			}
			public static int ic_lock_lock
			{
				get
				{
					return 17301551;
				}
			}
			public static int ic_lock_power_off
			{
				get
				{
					return 17301552;
				}
			}
			public static int ic_lock_silent_mode
			{
				get
				{
					return 17301553;
				}
			}
			public static int ic_lock_silent_mode_off
			{
				get
				{
					return 17301554;
				}
			}
			public static int ic_media_ff
			{
				get
				{
					return 17301537;
				}
			}
			public static int ic_media_next
			{
				get
				{
					return 17301538;
				}
			}
			public static int ic_media_pause
			{
				get
				{
					return 17301539;
				}
			}
			public static int ic_media_play
			{
				get
				{
					return 17301540;
				}
			}
			public static int ic_media_previous
			{
				get
				{
					return 17301541;
				}
			}
			public static int ic_media_rew
			{
				get
				{
					return 17301542;
				}
			}
			public static int ic_menu_add
			{
				get
				{
					return 17301555;
				}
			}
			public static int ic_menu_agenda
			{
				get
				{
					return 17301556;
				}
			}
			public static int ic_menu_always_landscape_portrait
			{
				get
				{
					return 17301557;
				}
			}
			public static int ic_menu_call
			{
				get
				{
					return 17301558;
				}
			}
			public static int ic_menu_camera
			{
				get
				{
					return 17301559;
				}
			}
			public static int ic_menu_close_clear_cancel
			{
				get
				{
					return 17301560;
				}
			}
			public static int ic_menu_compass
			{
				get
				{
					return 17301561;
				}
			}
			public static int ic_menu_crop
			{
				get
				{
					return 17301562;
				}
			}
			public static int ic_menu_day
			{
				get
				{
					return 17301563;
				}
			}
			public static int ic_menu_delete
			{
				get
				{
					return 17301564;
				}
			}
			public static int ic_menu_directions
			{
				get
				{
					return 17301565;
				}
			}
			public static int ic_menu_edit
			{
				get
				{
					return 17301566;
				}
			}
			public static int ic_menu_gallery
			{
				get
				{
					return 17301567;
				}
			}
			public static int ic_menu_help
			{
				get
				{
					return 17301568;
				}
			}
			public static int ic_menu_info_details
			{
				get
				{
					return 17301569;
				}
			}
			public static int ic_menu_manage
			{
				get
				{
					return 17301570;
				}
			}
			public static int ic_menu_mapmode
			{
				get
				{
					return 17301571;
				}
			}
			public static int ic_menu_month
			{
				get
				{
					return 17301572;
				}
			}
			public static int ic_menu_more
			{
				get
				{
					return 17301573;
				}
			}
			public static int ic_menu_my_calendar
			{
				get
				{
					return 17301574;
				}
			}
			public static int ic_menu_mylocation
			{
				get
				{
					return 17301575;
				}
			}
			public static int ic_menu_myplaces
			{
				get
				{
					return 17301576;
				}
			}
			public static int ic_menu_preferences
			{
				get
				{
					return 17301577;
				}
			}
			public static int ic_menu_recent_history
			{
				get
				{
					return 17301578;
				}
			}
			public static int ic_menu_report_image
			{
				get
				{
					return 17301579;
				}
			}
			public static int ic_menu_revert
			{
				get
				{
					return 17301580;
				}
			}
			public static int ic_menu_rotate
			{
				get
				{
					return 17301581;
				}
			}
			public static int ic_menu_save
			{
				get
				{
					return 17301582;
				}
			}
			public static int ic_menu_search
			{
				get
				{
					return 17301583;
				}
			}
			public static int ic_menu_send
			{
				get
				{
					return 17301584;
				}
			}
			public static int ic_menu_set_as
			{
				get
				{
					return 17301585;
				}
			}
			public static int ic_menu_share
			{
				get
				{
					return 17301586;
				}
			}
			public static int ic_menu_slideshow
			{
				get
				{
					return 17301587;
				}
			}
			public static int ic_menu_sort_alphabetically
			{
				get
				{
					return 17301660;
				}
			}
			public static int ic_menu_sort_by_size
			{
				get
				{
					return 17301661;
				}
			}
			public static int ic_menu_today
			{
				get
				{
					return 17301588;
				}
			}
			public static int ic_menu_upload
			{
				get
				{
					return 17301589;
				}
			}
			public static int ic_menu_upload_you_tube
			{
				get
				{
					return 17301590;
				}
			}
			public static int ic_menu_view
			{
				get
				{
					return 17301591;
				}
			}
			public static int ic_menu_week
			{
				get
				{
					return 17301592;
				}
			}
			public static int ic_menu_zoom
			{
				get
				{
					return 17301593;
				}
			}
			public static int ic_notification_clear_all
			{
				get
				{
					return 17301594;
				}
			}
			public static int ic_notification_overlay
			{
				get
				{
					return 17301595;
				}
			}
			public static int ic_partial_secure
			{
				get
				{
					return 17301596;
				}
			}
			public static int ic_popup_disk_full
			{
				get
				{
					return 17301597;
				}
			}
			public static int ic_popup_reminder
			{
				get
				{
					return 17301598;
				}
			}
			public static int ic_popup_sync
			{
				get
				{
					return 17301599;
				}
			}
			public static int ic_search_category_default
			{
				get
				{
					return 17301600;
				}
			}
			public static int ic_secure
			{
				get
				{
					return 17301601;
				}
			}
			public static int list_selector_background
			{
				get
				{
					return 17301602;
				}
			}
			public static int menu_frame
			{
				get
				{
					return 17301603;
				}
			}
			public static int menu_full_frame
			{
				get
				{
					return 17301604;
				}
			}
			public static int menuitem_background
			{
				get
				{
					return 17301605;
				}
			}
			public static int picture_frame
			{
				get
				{
					return 17301606;
				}
			}
			public static int presence_away
			{
				get
				{
					return 17301607;
				}
			}
			public static int presence_busy
			{
				get
				{
					return 17301608;
				}
			}
			public static int presence_invisible
			{
				get
				{
					return 17301609;
				}
			}
			public static int presence_offline
			{
				get
				{
					return 17301610;
				}
			}
			public static int presence_online
			{
				get
				{
					return 17301611;
				}
			}
			public static int progress_horizontal
			{
				get
				{
					return 17301612;
				}
			}
			public static int progress_indeterminate_horizontal
			{
				get
				{
					return 17301613;
				}
			}
			public static int radiobutton_off_background
			{
				get
				{
					return 17301614;
				}
			}
			public static int radiobutton_on_background
			{
				get
				{
					return 17301615;
				}
			}
			public static int screen_background_dark
			{
				get
				{
					return 17301656;
				}
			}
			public static int screen_background_dark_transparent
			{
				get
				{
					return 17301673;
				}
			}
			public static int screen_background_light
			{
				get
				{
					return 17301657;
				}
			}
			public static int screen_background_light_transparent
			{
				get
				{
					return 17301674;
				}
			}
			public static int spinner_background
			{
				get
				{
					return 17301616;
				}
			}
			public static int spinner_dropdown_background
			{
				get
				{
					return 17301617;
				}
			}
			public static int star_big_off
			{
				get
				{
					return 17301619;
				}
			}
			public static int star_big_on
			{
				get
				{
					return 17301618;
				}
			}
			public static int star_off
			{
				get
				{
					return 17301621;
				}
			}
			public static int star_on
			{
				get
				{
					return 17301620;
				}
			}
			public static int stat_notify_call_mute
			{
				get
				{
					return 17301622;
				}
			}
			public static int stat_notify_chat
			{
				get
				{
					return 17301623;
				}
			}
			public static int stat_notify_error
			{
				get
				{
					return 17301624;
				}
			}
			public static int stat_notify_missed_call
			{
				get
				{
					return 17301631;
				}
			}
			public static int stat_notify_more
			{
				get
				{
					return 17301625;
				}
			}
			public static int stat_notify_sdcard
			{
				get
				{
					return 17301626;
				}
			}
			public static int stat_notify_sdcard_prepare
			{
				get
				{
					return 17301675;
				}
			}
			public static int stat_notify_sdcard_usb
			{
				get
				{
					return 17301627;
				}
			}
			public static int stat_notify_sync
			{
				get
				{
					return 17301628;
				}
			}
			public static int stat_notify_sync_noanim
			{
				get
				{
					return 17301629;
				}
			}
			public static int stat_notify_voicemail
			{
				get
				{
					return 17301630;
				}
			}
			public static int stat_sys_data_bluetooth
			{
				get
				{
					return 17301632;
				}
			}
			public static int stat_sys_download
			{
				get
				{
					return 17301633;
				}
			}
			public static int stat_sys_download_done
			{
				get
				{
					return 17301634;
				}
			}
			public static int stat_sys_headset
			{
				get
				{
					return 17301635;
				}
			}
			public static int stat_sys_phone_call
			{
				get
				{
					return 17301636;
				}
			}
			public static int stat_sys_phone_call_forward
			{
				get
				{
					return 17301637;
				}
			}
			public static int stat_sys_phone_call_on_hold
			{
				get
				{
					return 17301638;
				}
			}
			public static int stat_sys_speakerphone
			{
				get
				{
					return 17301639;
				}
			}
			public static int stat_sys_upload
			{
				get
				{
					return 17301640;
				}
			}
			public static int stat_sys_upload_done
			{
				get
				{
					return 17301641;
				}
			}
			public static int stat_sys_vp_phone_call
			{
				get
				{
					return 17301671;
				}
			}
			public static int stat_sys_vp_phone_call_on_hold
			{
				get
				{
					return 17301672;
				}
			}
			public static int stat_sys_warning
			{
				get
				{
					return 17301642;
				}
			}
			public static int status_bar_item_app_background
			{
				get
				{
					return 17301643;
				}
			}
			public static int status_bar_item_background
			{
				get
				{
					return 17301644;
				}
			}
			public static int sym_action_call
			{
				get
				{
					return 17301645;
				}
			}
			public static int sym_action_chat
			{
				get
				{
					return 17301646;
				}
			}
			public static int sym_action_email
			{
				get
				{
					return 17301647;
				}
			}
			public static int sym_call_incoming
			{
				get
				{
					return 17301648;
				}
			}
			public static int sym_call_missed
			{
				get
				{
					return 17301649;
				}
			}
			public static int sym_call_outgoing
			{
				get
				{
					return 17301650;
				}
			}
			public static int sym_contact_card
			{
				get
				{
					return 17301652;
				}
			}
			public static int sym_def_app_icon
			{
				get
				{
					return 17301651;
				}
			}
			public static int title_bar
			{
				get
				{
					return 17301653;
				}
			}
			public static int title_bar_tall
			{
				get
				{
					return 17301670;
				}
			}
			public static int toast_frame
			{
				get
				{
					return 17301654;
				}
			}
			public static int zoom_plate
			{
				get
				{
					return 17301655;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.R.drawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/R$drawable"));
				global::android.R.drawable._drawable9 = @__env.GetMethodIDNoThrow(global::android.R.drawable.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class id : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static id()
			{
				InitJNI();
			}
			internal id(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _id10;
			public id()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.R.id.staticClass, global::android.R.id._id10);
				Init(@__env, handle);
			}
			public static int addToDictionary
			{
				get
				{
					return 16908330;
				}
			}
			public static int background
			{
				get
				{
					return 16908288;
				}
			}
			public static int button1
			{
				get
				{
					return 16908313;
				}
			}
			public static int button2
			{
				get
				{
					return 16908314;
				}
			}
			public static int button3
			{
				get
				{
					return 16908315;
				}
			}
			public static int candidatesArea
			{
				get
				{
					return 16908317;
				}
			}
			public static int checkbox
			{
				get
				{
					return 16908289;
				}
			}
			public static int closeButton
			{
				get
				{
					return 16908327;
				}
			}
			public static int content
			{
				get
				{
					return 16908290;
				}
			}
			public static int copy
			{
				get
				{
					return 16908321;
				}
			}
			public static int copyUrl
			{
				get
				{
					return 16908323;
				}
			}
			public static int custom
			{
				get
				{
					return 16908331;
				}
			}
			public static int cut
			{
				get
				{
					return 16908320;
				}
			}
			public static int edit
			{
				get
				{
					return 16908291;
				}
			}
			public static int empty
			{
				get
				{
					return 16908292;
				}
			}
			public static int extractArea
			{
				get
				{
					return 16908316;
				}
			}
			public static int hint
			{
				get
				{
					return 16908293;
				}
			}
			public static int icon
			{
				get
				{
					return 16908294;
				}
			}
			public static int icon1
			{
				get
				{
					return 16908295;
				}
			}
			public static int icon2
			{
				get
				{
					return 16908296;
				}
			}
			public static int input
			{
				get
				{
					return 16908297;
				}
			}
			public static int inputArea
			{
				get
				{
					return 16908318;
				}
			}
			public static int inputExtractEditText
			{
				get
				{
					return 16908325;
				}
			}
			public static int keyboardView
			{
				get
				{
					return 16908326;
				}
			}
			public static int list
			{
				get
				{
					return 16908298;
				}
			}
			public static int message
			{
				get
				{
					return 16908299;
				}
			}
			public static int paste
			{
				get
				{
					return 16908322;
				}
			}
			public static int primary
			{
				get
				{
					return 16908300;
				}
			}
			public static int progress
			{
				get
				{
					return 16908301;
				}
			}
			public static int secondaryProgress
			{
				get
				{
					return 16908303;
				}
			}
			public static int selectAll
			{
				get
				{
					return 16908319;
				}
			}
			public static int selectedIcon
			{
				get
				{
					return 16908302;
				}
			}
			public static int startSelectingText
			{
				get
				{
					return 16908328;
				}
			}
			public static int stopSelectingText
			{
				get
				{
					return 16908329;
				}
			}
			public static int summary
			{
				get
				{
					return 16908304;
				}
			}
			public static int switchInputMethod
			{
				get
				{
					return 16908324;
				}
			}
			public static int tabcontent
			{
				get
				{
					return 16908305;
				}
			}
			public static int tabhost
			{
				get
				{
					return 16908306;
				}
			}
			public static int tabs
			{
				get
				{
					return 16908307;
				}
			}
			public static int text1
			{
				get
				{
					return 16908308;
				}
			}
			public static int text2
			{
				get
				{
					return 16908309;
				}
			}
			public static int title
			{
				get
				{
					return 16908310;
				}
			}
			public static int toggle
			{
				get
				{
					return 16908311;
				}
			}
			public static int widget_frame
			{
				get
				{
					return 16908312;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.R.id.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/R$id"));
				global::android.R.id._id10 = @__env.GetMethodIDNoThrow(global::android.R.id.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class integer : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static integer()
			{
				InitJNI();
			}
			internal integer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _integer11;
			public integer()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.R.integer.staticClass, global::android.R.integer._integer11);
				Init(@__env, handle);
			}
			public static int config_longAnimTime
			{
				get
				{
					return 17694722;
				}
			}
			public static int config_mediumAnimTime
			{
				get
				{
					return 17694721;
				}
			}
			public static int config_shortAnimTime
			{
				get
				{
					return 17694720;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.R.integer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/R$integer"));
				global::android.R.integer._integer11 = @__env.GetMethodIDNoThrow(global::android.R.integer.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class layout : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static layout()
			{
				InitJNI();
			}
			internal layout(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _layout12;
			public layout()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.R.layout.staticClass, global::android.R.layout._layout12);
				Init(@__env, handle);
			}
			public static int activity_list_item
			{
				get
				{
					return 17367040;
				}
			}
			public static int browser_link_context_header
			{
				get
				{
					return 17367054;
				}
			}
			public static int expandable_list_content
			{
				get
				{
					return 17367041;
				}
			}
			public static int preference_category
			{
				get
				{
					return 17367042;
				}
			}
			public static int select_dialog_item
			{
				get
				{
					return 17367057;
				}
			}
			public static int select_dialog_multichoice
			{
				get
				{
					return 17367059;
				}
			}
			public static int select_dialog_singlechoice
			{
				get
				{
					return 17367058;
				}
			}
			public static int simple_dropdown_item_1line
			{
				get
				{
					return 17367050;
				}
			}
			public static int simple_expandable_list_item_1
			{
				get
				{
					return 17367046;
				}
			}
			public static int simple_expandable_list_item_2
			{
				get
				{
					return 17367047;
				}
			}
			public static int simple_gallery_item
			{
				get
				{
					return 17367051;
				}
			}
			public static int simple_list_item_1
			{
				get
				{
					return 17367043;
				}
			}
			public static int simple_list_item_2
			{
				get
				{
					return 17367044;
				}
			}
			public static int simple_list_item_checked
			{
				get
				{
					return 17367045;
				}
			}
			public static int simple_list_item_multiple_choice
			{
				get
				{
					return 17367056;
				}
			}
			public static int simple_list_item_single_choice
			{
				get
				{
					return 17367055;
				}
			}
			public static int simple_spinner_dropdown_item
			{
				get
				{
					return 17367049;
				}
			}
			public static int simple_spinner_item
			{
				get
				{
					return 17367048;
				}
			}
			public static int test_list_item
			{
				get
				{
					return 17367052;
				}
			}
			public static int two_line_list_item
			{
				get
				{
					return 17367053;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.R.layout.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/R$layout"));
				global::android.R.layout._layout12 = @__env.GetMethodIDNoThrow(global::android.R.layout.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class plurals : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static plurals()
			{
				InitJNI();
			}
			internal plurals(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _plurals13;
			public plurals()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.R.plurals.staticClass, global::android.R.plurals._plurals13);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.R.plurals.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/R$plurals"));
				global::android.R.plurals._plurals13 = @__env.GetMethodIDNoThrow(global::android.R.plurals.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class raw : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static raw()
			{
				InitJNI();
			}
			internal raw(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _raw14;
			public raw()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.R.raw.staticClass, global::android.R.raw._raw14);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.R.raw.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/R$raw"));
				global::android.R.raw._raw14 = @__env.GetMethodIDNoThrow(global::android.R.raw.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class @string : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static @string()
			{
				InitJNI();
			}
			internal @string(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _string15;
			public @string()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.R.@string.staticClass, global::android.R.@string._string15);
				Init(@__env, handle);
			}
			public static int VideoView_error_button
			{
				get
				{
					return 17039376;
				}
			}
			public static int VideoView_error_text_invalid_progressive_playback
			{
				get
				{
					return 17039381;
				}
			}
			public static int VideoView_error_text_unknown
			{
				get
				{
					return 17039377;
				}
			}
			public static int VideoView_error_title
			{
				get
				{
					return 17039378;
				}
			}
			public static int cancel
			{
				get
				{
					return 17039360;
				}
			}
			public static int copy
			{
				get
				{
					return 17039361;
				}
			}
			public static int copyUrl
			{
				get
				{
					return 17039362;
				}
			}
			public static int cut
			{
				get
				{
					return 17039363;
				}
			}
			public static int defaultMsisdnAlphaTag
			{
				get
				{
					return 17039365;
				}
			}
			public static int defaultVoiceMailAlphaTag
			{
				get
				{
					return 17039364;
				}
			}
			public static int dialog_alert_title
			{
				get
				{
					return 17039380;
				}
			}
			public static int emptyPhoneNumber
			{
				get
				{
					return 17039366;
				}
			}
			public static int httpErrorBadUrl
			{
				get
				{
					return 17039367;
				}
			}
			public static int httpErrorUnsupportedScheme
			{
				get
				{
					return 17039368;
				}
			}
			public static int no
			{
				get
				{
					return 17039369;
				}
			}
			public static int ok
			{
				get
				{
					return 17039370;
				}
			}
			public static int paste
			{
				get
				{
					return 17039371;
				}
			}
			public static int search_go
			{
				get
				{
					return 17039372;
				}
			}
			public static int selectAll
			{
				get
				{
					return 17039373;
				}
			}
			public static int unknownName
			{
				get
				{
					return 17039374;
				}
			}
			public static int untitled
			{
				get
				{
					return 17039375;
				}
			}
			public static int yes
			{
				get
				{
					return 17039379;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.R.@string.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/R$@string"));
				global::android.R.@string._string15 = @__env.GetMethodIDNoThrow(global::android.R.@string.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class style : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static style()
			{
				InitJNI();
			}
			internal style(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _style16;
			public style()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.R.style.staticClass, global::android.R.style._style16);
				Init(@__env, handle);
			}
			public static int Animation
			{
				get
				{
					return 16973824;
				}
			}
			public static int Animation_Activity
			{
				get
				{
					return 16973825;
				}
			}
			public static int Animation_Dialog
			{
				get
				{
					return 16973826;
				}
			}
			public static int Animation_InputMethod
			{
				get
				{
					return 16973910;
				}
			}
			public static int Animation_Toast
			{
				get
				{
					return 16973828;
				}
			}
			public static int Animation_Translucent
			{
				get
				{
					return 16973827;
				}
			}
			public static int MediaButton
			{
				get
				{
					return 16973879;
				}
			}
			public static int MediaButton_Ffwd
			{
				get
				{
					return 16973883;
				}
			}
			public static int MediaButton_Next
			{
				get
				{
					return 16973881;
				}
			}
			public static int MediaButton_Pause
			{
				get
				{
					return 16973885;
				}
			}
			public static int MediaButton_Play
			{
				get
				{
					return 16973882;
				}
			}
			public static int MediaButton_Previous
			{
				get
				{
					return 16973880;
				}
			}
			public static int MediaButton_Rew
			{
				get
				{
					return 16973884;
				}
			}
			public static int TextAppearance
			{
				get
				{
					return 16973886;
				}
			}
			public static int TextAppearance_DialogWindowTitle
			{
				get
				{
					return 16973889;
				}
			}
			public static int TextAppearance_Inverse
			{
				get
				{
					return 16973887;
				}
			}
			public static int TextAppearance_Large
			{
				get
				{
					return 16973890;
				}
			}
			public static int TextAppearance_Large_Inverse
			{
				get
				{
					return 16973891;
				}
			}
			public static int TextAppearance_Medium
			{
				get
				{
					return 16973892;
				}
			}
			public static int TextAppearance_Medium_Inverse
			{
				get
				{
					return 16973893;
				}
			}
			public static int TextAppearance_Small
			{
				get
				{
					return 16973894;
				}
			}
			public static int TextAppearance_Small_Inverse
			{
				get
				{
					return 16973895;
				}
			}
			public static int TextAppearance_Theme
			{
				get
				{
					return 16973888;
				}
			}
			public static int TextAppearance_Theme_Dialog
			{
				get
				{
					return 16973896;
				}
			}
			public static int TextAppearance_Widget
			{
				get
				{
					return 16973897;
				}
			}
			public static int TextAppearance_Widget_Button
			{
				get
				{
					return 16973898;
				}
			}
			public static int TextAppearance_Widget_DropDownHint
			{
				get
				{
					return 16973904;
				}
			}
			public static int TextAppearance_Widget_DropDownItem
			{
				get
				{
					return 16973905;
				}
			}
			public static int TextAppearance_Widget_EditText
			{
				get
				{
					return 16973900;
				}
			}
			public static int TextAppearance_Widget_IconMenu_Item
			{
				get
				{
					return 16973899;
				}
			}
			public static int TextAppearance_Widget_TabWidget
			{
				get
				{
					return 16973901;
				}
			}
			public static int TextAppearance_Widget_TextView
			{
				get
				{
					return 16973902;
				}
			}
			public static int TextAppearance_Widget_TextView_PopupMenu
			{
				get
				{
					return 16973903;
				}
			}
			public static int TextAppearance_Widget_TextView_SpinnerItem
			{
				get
				{
					return 16973906;
				}
			}
			public static int TextAppearance_WindowTitle
			{
				get
				{
					return 16973907;
				}
			}
			public static int Theme
			{
				get
				{
					return 16973829;
				}
			}
			public static int Theme_Black
			{
				get
				{
					return 16973832;
				}
			}
			public static int Theme_Black_NoTitleBar
			{
				get
				{
					return 16973833;
				}
			}
			public static int Theme_Black_NoTitleBar_Fullscreen
			{
				get
				{
					return 16973834;
				}
			}
			public static int Theme_Dialog
			{
				get
				{
					return 16973835;
				}
			}
			public static int Theme_InputMethod
			{
				get
				{
					return 16973908;
				}
			}
			public static int Theme_Light
			{
				get
				{
					return 16973836;
				}
			}
			public static int Theme_Light_NoTitleBar
			{
				get
				{
					return 16973837;
				}
			}
			public static int Theme_Light_NoTitleBar_Fullscreen
			{
				get
				{
					return 16973838;
				}
			}
			public static int Theme_Light_Panel
			{
				get
				{
					return 16973914;
				}
			}
			public static int Theme_Light_WallpaperSettings
			{
				get
				{
					return 16973922;
				}
			}
			public static int Theme_NoDisplay
			{
				get
				{
					return 16973909;
				}
			}
			public static int Theme_NoTitleBar
			{
				get
				{
					return 16973830;
				}
			}
			public static int Theme_NoTitleBar_Fullscreen
			{
				get
				{
					return 16973831;
				}
			}
			public static int Theme_Panel
			{
				get
				{
					return 16973913;
				}
			}
			public static int Theme_Translucent
			{
				get
				{
					return 16973839;
				}
			}
			public static int Theme_Translucent_NoTitleBar
			{
				get
				{
					return 16973840;
				}
			}
			public static int Theme_Translucent_NoTitleBar_Fullscreen
			{
				get
				{
					return 16973841;
				}
			}
			public static int Theme_Wallpaper
			{
				get
				{
					return 16973918;
				}
			}
			public static int Theme_Wallpaper_NoTitleBar
			{
				get
				{
					return 16973919;
				}
			}
			public static int Theme_Wallpaper_NoTitleBar_Fullscreen
			{
				get
				{
					return 16973920;
				}
			}
			public static int Theme_WallpaperSettings
			{
				get
				{
					return 16973921;
				}
			}
			public static int Widget
			{
				get
				{
					return 16973842;
				}
			}
			public static int Widget_AbsListView
			{
				get
				{
					return 16973843;
				}
			}
			public static int Widget_AutoCompleteTextView
			{
				get
				{
					return 16973863;
				}
			}
			public static int Widget_Button
			{
				get
				{
					return 16973844;
				}
			}
			public static int Widget_Button_Inset
			{
				get
				{
					return 16973845;
				}
			}
			public static int Widget_Button_Small
			{
				get
				{
					return 16973846;
				}
			}
			public static int Widget_Button_Toggle
			{
				get
				{
					return 16973847;
				}
			}
			public static int Widget_CompoundButton
			{
				get
				{
					return 16973848;
				}
			}
			public static int Widget_CompoundButton_CheckBox
			{
				get
				{
					return 16973849;
				}
			}
			public static int Widget_CompoundButton_RadioButton
			{
				get
				{
					return 16973850;
				}
			}
			public static int Widget_CompoundButton_Star
			{
				get
				{
					return 16973851;
				}
			}
			public static int Widget_DropDownItem
			{
				get
				{
					return 16973867;
				}
			}
			public static int Widget_DropDownItem_Spinner
			{
				get
				{
					return 16973868;
				}
			}
			public static int Widget_EditText
			{
				get
				{
					return 16973859;
				}
			}
			public static int Widget_ExpandableListView
			{
				get
				{
					return 16973860;
				}
			}
			public static int Widget_Gallery
			{
				get
				{
					return 16973877;
				}
			}
			public static int Widget_GridView
			{
				get
				{
					return 16973874;
				}
			}
			public static int Widget_ImageButton
			{
				get
				{
					return 16973862;
				}
			}
			public static int Widget_ImageWell
			{
				get
				{
					return 16973861;
				}
			}
			public static int Widget_KeyboardView
			{
				get
				{
					return 16973911;
				}
			}
			public static int Widget_ListView
			{
				get
				{
					return 16973870;
				}
			}
			public static int Widget_ListView_DropDown
			{
				get
				{
					return 16973872;
				}
			}
			public static int Widget_ListView_Menu
			{
				get
				{
					return 16973873;
				}
			}
			public static int Widget_ListView_White
			{
				get
				{
					return 16973871;
				}
			}
			public static int Widget_PopupWindow
			{
				get
				{
					return 16973878;
				}
			}
			public static int Widget_ProgressBar
			{
				get
				{
					return 16973852;
				}
			}
			public static int Widget_ProgressBar_Horizontal
			{
				get
				{
					return 16973855;
				}
			}
			public static int Widget_ProgressBar_Inverse
			{
				get
				{
					return 16973915;
				}
			}
			public static int Widget_ProgressBar_Large
			{
				get
				{
					return 16973853;
				}
			}
			public static int Widget_ProgressBar_Large_Inverse
			{
				get
				{
					return 16973916;
				}
			}
			public static int Widget_ProgressBar_Small
			{
				get
				{
					return 16973854;
				}
			}
			public static int Widget_ProgressBar_Small_Inverse
			{
				get
				{
					return 16973917;
				}
			}
			public static int Widget_RatingBar
			{
				get
				{
					return 16973857;
				}
			}
			public static int Widget_ScrollView
			{
				get
				{
					return 16973869;
				}
			}
			public static int Widget_SeekBar
			{
				get
				{
					return 16973856;
				}
			}
			public static int Widget_Spinner
			{
				get
				{
					return 16973864;
				}
			}
			public static int Widget_TabWidget
			{
				get
				{
					return 16973876;
				}
			}
			public static int Widget_TextView
			{
				get
				{
					return 16973858;
				}
			}
			public static int Widget_TextView_PopupMenu
			{
				get
				{
					return 16973865;
				}
			}
			public static int Widget_TextView_SpinnerItem
			{
				get
				{
					return 16973866;
				}
			}
			public static int Widget_WebView
			{
				get
				{
					return 16973875;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.R.style.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/R$style"));
				global::android.R.style._style16 = @__env.GetMethodIDNoThrow(global::android.R.style.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class xml : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static xml()
			{
				InitJNI();
			}
			internal xml(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _xml17;
			public xml()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.R.xml.staticClass, global::android.R.xml._xml17);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.R.xml.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/R$xml"));
				global::android.R.xml._xml17 = @__env.GetMethodIDNoThrow(global::android.R.xml.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _R18;
		public R()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.R.staticClass, global::android.R._R18);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.R.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/R"));
			global::android.R._R18 = @__env.GetMethodIDNoThrow(global::android.R.staticClass, "<init>", "()V");
		}
	}
}
