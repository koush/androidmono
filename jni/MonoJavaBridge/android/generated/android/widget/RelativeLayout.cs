namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RelativeLayout : android.view.ViewGroup
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RelativeLayout()
		{
			InitJNI();
		}
		protected RelativeLayout(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public new partial class LayoutParams : android.view.ViewGroup.MarginLayoutParams
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static LayoutParams()
			{
				InitJNI();
			}
			protected LayoutParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _debug12298;
			public virtual global::java.lang.String debug(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.RelativeLayout.LayoutParams._debug12298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.RelativeLayout.LayoutParams.staticClass, global::android.widget.RelativeLayout.LayoutParams._debug12298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _addRule12299;
			public virtual void addRule(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout.LayoutParams._addRule12299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout.LayoutParams.staticClass, global::android.widget.RelativeLayout.LayoutParams._addRule12299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _addRule12300;
			public virtual void addRule(int arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout.LayoutParams._addRule12300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout.LayoutParams.staticClass, global::android.widget.RelativeLayout.LayoutParams._addRule12300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			public new int[] Rules
			{
				get
				{
					return getRules();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getRules12301;
			public virtual int[] getRules() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.RelativeLayout.LayoutParams._getRules12301)) as int[];
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.RelativeLayout.LayoutParams.staticClass, global::android.widget.RelativeLayout.LayoutParams._getRules12301)) as int[];
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams12302;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RelativeLayout.LayoutParams.staticClass, global::android.widget.RelativeLayout.LayoutParams._LayoutParams12302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams12303;
			public LayoutParams(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RelativeLayout.LayoutParams.staticClass, global::android.widget.RelativeLayout.LayoutParams._LayoutParams12303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams12304;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RelativeLayout.LayoutParams.staticClass, global::android.widget.RelativeLayout.LayoutParams._LayoutParams12304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams12305;
			public LayoutParams(android.view.ViewGroup.MarginLayoutParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RelativeLayout.LayoutParams.staticClass, global::android.widget.RelativeLayout.LayoutParams._LayoutParams12305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _alignWithParent12306;
			public bool alignWithParent
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.RelativeLayout.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RelativeLayout$LayoutParams"));
				global::android.widget.RelativeLayout.LayoutParams._debug12298 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.LayoutParams.staticClass, "debug", "(Ljava/lang/String;)Ljava/lang/String;");
				global::android.widget.RelativeLayout.LayoutParams._addRule12299 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.LayoutParams.staticClass, "addRule", "(I)V");
				global::android.widget.RelativeLayout.LayoutParams._addRule12300 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.LayoutParams.staticClass, "addRule", "(II)V");
				global::android.widget.RelativeLayout.LayoutParams._getRules12301 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.LayoutParams.staticClass, "getRules", "()[I");
				global::android.widget.RelativeLayout.LayoutParams._LayoutParams12302 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.widget.RelativeLayout.LayoutParams._LayoutParams12303 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.LayoutParams.staticClass, "<init>", "(II)V");
				global::android.widget.RelativeLayout.LayoutParams._LayoutParams12304 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::android.widget.RelativeLayout.LayoutParams._LayoutParams12305 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent12307;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.RelativeLayout._dispatchPopulateAccessibilityEvent12307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._dispatchPopulateAccessibilityEvent12307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setGravity12308;
		public virtual void setGravity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout._setGravity12308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._setGravity12308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onLayout12309;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout._onLayout12309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._onLayout12309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		public new int Baseline
		{
			get
			{
				return getBaseline();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getBaseline12310;
		public override int getBaseline() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.RelativeLayout._getBaseline12310);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._getBaseline12310);
		}
		internal static global::MonoJavaBridge.MethodId _requestLayout12311;
		public override void requestLayout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout._requestLayout12311);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._requestLayout12311);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure12312;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout._onMeasure12312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._onMeasure12312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkLayoutParams12313;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.RelativeLayout._checkLayoutParams12313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._checkLayoutParams12313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams12314;
		public virtual global::android.widget.RelativeLayout.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.RelativeLayout._generateLayoutParams12314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.RelativeLayout.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._generateLayoutParams12314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.RelativeLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams12315;
		protected override global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.RelativeLayout._generateLayoutParams12315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._generateLayoutParams12315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateDefaultLayoutParams12316;
		protected override global::android.view.ViewGroup.LayoutParams generateDefaultLayoutParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.RelativeLayout._generateDefaultLayoutParams12316)) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._generateDefaultLayoutParams12316)) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _setHorizontalGravity12317;
		public virtual void setHorizontalGravity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout._setHorizontalGravity12317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._setHorizontalGravity12317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVerticalGravity12318;
		public virtual void setVerticalGravity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout._setVerticalGravity12318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._setVerticalGravity12318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setIgnoreGravity12319;
		public virtual void setIgnoreGravity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout._setIgnoreGravity12319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._setIgnoreGravity12319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _RelativeLayout12320;
		public RelativeLayout(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._RelativeLayout12320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RelativeLayout12321;
		public RelativeLayout(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._RelativeLayout12321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RelativeLayout12322;
		public RelativeLayout(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._RelativeLayout12322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.RelativeLayout.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/RelativeLayout"));
			global::android.widget.RelativeLayout._dispatchPopulateAccessibilityEvent12307 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.widget.RelativeLayout._setGravity12308 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "setGravity", "(I)V");
			global::android.widget.RelativeLayout._onLayout12309 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.RelativeLayout._getBaseline12310 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "getBaseline", "()I");
			global::android.widget.RelativeLayout._requestLayout12311 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "requestLayout", "()V");
			global::android.widget.RelativeLayout._onMeasure12312 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "onMeasure", "(II)V");
			global::android.widget.RelativeLayout._checkLayoutParams12313 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z");
			global::android.widget.RelativeLayout._generateLayoutParams12314 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/RelativeLayout$LayoutParams;");
			global::android.widget.RelativeLayout._generateLayoutParams12315 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;");
			global::android.widget.RelativeLayout._generateDefaultLayoutParams12316 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;");
			global::android.widget.RelativeLayout._setHorizontalGravity12317 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "setHorizontalGravity", "(I)V");
			global::android.widget.RelativeLayout._setVerticalGravity12318 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "setVerticalGravity", "(I)V");
			global::android.widget.RelativeLayout._setIgnoreGravity12319 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "setIgnoreGravity", "(I)V");
			global::android.widget.RelativeLayout._RelativeLayout12320 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.RelativeLayout._RelativeLayout12321 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.RelativeLayout._RelativeLayout12322 = @__env.GetMethodIDNoThrow(global::android.widget.RelativeLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
