namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RelativeLayout : android.view.ViewGroup
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RelativeLayout(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public new partial class LayoutParams : android.view.ViewGroup.MarginLayoutParams
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected LayoutParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _debug17573;
			public virtual global::java.lang.String debug(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.RelativeLayout.LayoutParams._debug17573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.RelativeLayout.LayoutParams.staticClass, global::android.widget.RelativeLayout.LayoutParams._debug17573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _addRule17574;
			public virtual void addRule(int arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout.LayoutParams._addRule17574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout.LayoutParams.staticClass, global::android.widget.RelativeLayout.LayoutParams._addRule17574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _addRule17575;
			public virtual void addRule(int arg0, int arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout.LayoutParams._addRule17575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout.LayoutParams.staticClass, global::android.widget.RelativeLayout.LayoutParams._addRule17575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			public new int[] Rules
			{
				get
				{
					return getRules();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getRules17576;
			public virtual int[] getRules()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.RelativeLayout.LayoutParams._getRules17576)) as int[];
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.RelativeLayout.LayoutParams.staticClass, global::android.widget.RelativeLayout.LayoutParams._getRules17576)) as int[];
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17577;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RelativeLayout.LayoutParams.staticClass, global::android.widget.RelativeLayout.LayoutParams._LayoutParams17577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17578;
			public LayoutParams(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RelativeLayout.LayoutParams.staticClass, global::android.widget.RelativeLayout.LayoutParams._LayoutParams17578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17579;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RelativeLayout.LayoutParams.staticClass, global::android.widget.RelativeLayout.LayoutParams._LayoutParams17579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17580;
			public LayoutParams(android.view.ViewGroup.MarginLayoutParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RelativeLayout.LayoutParams.staticClass, global::android.widget.RelativeLayout.LayoutParams._LayoutParams17580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _alignWithParent17581;
			public bool alignWithParent
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetBooleanField(this.JvmHandle, _alignWithParent17581);
				}
				set
				{
				}
			}
			static LayoutParams()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.RelativeLayout.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RelativeLayout$LayoutParams"));
				global::android.widget.RelativeLayout.LayoutParams._debug17573 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.LayoutParams.staticClass, "debug", "(Ljava/lang/String;)Ljava/lang/String;");
				global::android.widget.RelativeLayout.LayoutParams._addRule17574 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.LayoutParams.staticClass, "addRule", "(I)V");
				global::android.widget.RelativeLayout.LayoutParams._addRule17575 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.LayoutParams.staticClass, "addRule", "(II)V");
				global::android.widget.RelativeLayout.LayoutParams._getRules17576 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.LayoutParams.staticClass, "getRules", "()[I");
				global::android.widget.RelativeLayout.LayoutParams._LayoutParams17577 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.widget.RelativeLayout.LayoutParams._LayoutParams17578 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.LayoutParams.staticClass, "<init>", "(II)V");
				global::android.widget.RelativeLayout.LayoutParams._LayoutParams17579 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::android.widget.RelativeLayout.LayoutParams._LayoutParams17580 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V");
				global::android.widget.RelativeLayout.LayoutParams._alignWithParent17581 = @__env.GetFieldIDNoThrow(global::android.widget.RelativeLayout.LayoutParams.staticClass, "alignWithParent", "Z");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent17582;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.RelativeLayout._dispatchPopulateAccessibilityEvent17582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._dispatchPopulateAccessibilityEvent17582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Gravity
		{
			set
			{
				setGravity(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setGravity17583;
		public virtual void setGravity(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout._setGravity17583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._setGravity17583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLayout17584;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout._onLayout17584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._onLayout17584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public new int Baseline
		{
			get
			{
				return getBaseline();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBaseline17585;
		public override int getBaseline()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.RelativeLayout._getBaseline17585);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._getBaseline17585);
		}
		internal static global::MonoJavaBridge.MethodId _requestLayout17586;
		public override void requestLayout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout._requestLayout17586);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._requestLayout17586);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure17587;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout._onMeasure17587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._onMeasure17587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkLayoutParams17588;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.RelativeLayout._checkLayoutParams17588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._checkLayoutParams17588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams17589;
		public virtual global::android.widget.RelativeLayout.LayoutParams generateLayoutParams(android.util.AttributeSet arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.RelativeLayout._generateLayoutParams17589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.RelativeLayout.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._generateLayoutParams17589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.RelativeLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams17590;
		protected override global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.RelativeLayout._generateLayoutParams17590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._generateLayoutParams17590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateDefaultLayoutParams17591;
		protected override global::android.view.ViewGroup.LayoutParams generateDefaultLayoutParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.RelativeLayout._generateDefaultLayoutParams17591)) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._generateDefaultLayoutParams17591)) as android.view.ViewGroup.LayoutParams;
		}
		public new int HorizontalGravity
		{
			set
			{
				setHorizontalGravity(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setHorizontalGravity17592;
		public virtual void setHorizontalGravity(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout._setHorizontalGravity17592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._setHorizontalGravity17592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int VerticalGravity
		{
			set
			{
				setVerticalGravity(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setVerticalGravity17593;
		public virtual void setVerticalGravity(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout._setVerticalGravity17593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._setVerticalGravity17593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int IgnoreGravity
		{
			set
			{
				setIgnoreGravity(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setIgnoreGravity17594;
		public virtual void setIgnoreGravity(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout._setIgnoreGravity17594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._setIgnoreGravity17594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _RelativeLayout17595;
		public RelativeLayout(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._RelativeLayout17595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RelativeLayout17596;
		public RelativeLayout(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._RelativeLayout17596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RelativeLayout17597;
		public RelativeLayout(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._RelativeLayout17597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		public static int TRUE
		{
			get
			{
				return -1;
			}
		}
		public static int LEFT_OF
		{
			get
			{
				return 0;
			}
		}
		public static int RIGHT_OF
		{
			get
			{
				return 1;
			}
		}
		public static int ABOVE
		{
			get
			{
				return 2;
			}
		}
		public static int BELOW
		{
			get
			{
				return 3;
			}
		}
		public static int ALIGN_BASELINE
		{
			get
			{
				return 4;
			}
		}
		public static int ALIGN_LEFT
		{
			get
			{
				return 5;
			}
		}
		public static int ALIGN_TOP
		{
			get
			{
				return 6;
			}
		}
		public static int ALIGN_RIGHT
		{
			get
			{
				return 7;
			}
		}
		public static int ALIGN_BOTTOM
		{
			get
			{
				return 8;
			}
		}
		public static int ALIGN_PARENT_LEFT
		{
			get
			{
				return 9;
			}
		}
		public static int ALIGN_PARENT_TOP
		{
			get
			{
				return 10;
			}
		}
		public static int ALIGN_PARENT_RIGHT
		{
			get
			{
				return 11;
			}
		}
		public static int ALIGN_PARENT_BOTTOM
		{
			get
			{
				return 12;
			}
		}
		public static int CENTER_IN_PARENT
		{
			get
			{
				return 13;
			}
		}
		public static int CENTER_HORIZONTAL
		{
			get
			{
				return 14;
			}
		}
		public static int CENTER_VERTICAL
		{
			get
			{
				return 15;
			}
		}
		static RelativeLayout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.RelativeLayout.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RelativeLayout"));
			global::android.widget.RelativeLayout._dispatchPopulateAccessibilityEvent17582 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.widget.RelativeLayout._setGravity17583 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "setGravity", "(I)V");
			global::android.widget.RelativeLayout._onLayout17584 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.RelativeLayout._getBaseline17585 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "getBaseline", "()I");
			global::android.widget.RelativeLayout._requestLayout17586 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "requestLayout", "()V");
			global::android.widget.RelativeLayout._onMeasure17587 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "onMeasure", "(II)V");
			global::android.widget.RelativeLayout._checkLayoutParams17588 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z");
			global::android.widget.RelativeLayout._generateLayoutParams17589 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/RelativeLayout$LayoutParams;");
			global::android.widget.RelativeLayout._generateLayoutParams17590 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;");
			global::android.widget.RelativeLayout._generateDefaultLayoutParams17591 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;");
			global::android.widget.RelativeLayout._setHorizontalGravity17592 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "setHorizontalGravity", "(I)V");
			global::android.widget.RelativeLayout._setVerticalGravity17593 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "setVerticalGravity", "(I)V");
			global::android.widget.RelativeLayout._setIgnoreGravity17594 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "setIgnoreGravity", "(I)V");
			global::android.widget.RelativeLayout._RelativeLayout17595 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.RelativeLayout._RelativeLayout17596 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.RelativeLayout._RelativeLayout17597 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
