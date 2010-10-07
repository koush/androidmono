namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class RelativeLayout : android.view.ViewGroup
	{
		internal new static global::java.lang.Class staticClass;
		static RelativeLayout()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.RelativeLayout), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.RelativeLayout(@__env);
			}
		}
		protected RelativeLayout(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public new class LayoutParams : android.view.ViewGroup.MarginLayoutParams
		{
			internal new static global::java.lang.Class staticClass;
			static LayoutParams()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.RelativeLayout.LayoutParams), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.widget.RelativeLayout.LayoutParams(@__env);
				}
			}
			protected LayoutParams(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _debug11373;
			public virtual global::java.lang.String debug(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.RelativeLayout.LayoutParams._debug11373, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.RelativeLayout.LayoutParams.staticClass, global::android.widget.RelativeLayout.LayoutParams._debug11373, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _addRule11374;
			public virtual void addRule(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.RelativeLayout.LayoutParams._addRule11374, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.RelativeLayout.LayoutParams.staticClass, global::android.widget.RelativeLayout.LayoutParams._addRule11374, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _addRule11375;
			public virtual void addRule(int arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.RelativeLayout.LayoutParams._addRule11375, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.RelativeLayout.LayoutParams.staticClass, global::android.widget.RelativeLayout.LayoutParams._addRule11375, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getRules11376;
			public virtual int[] getRules() 
			{
				if (!IsClrObject)
					return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.RelativeLayout.LayoutParams._getRules11376));
				else
					return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.RelativeLayout.LayoutParams.staticClass, global::android.widget.RelativeLayout.LayoutParams._getRules11376));
			}
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams11377;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.RelativeLayout.LayoutParams.staticClass, global::android.widget.RelativeLayout.LayoutParams._LayoutParams11377, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams11378;
			public LayoutParams(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.RelativeLayout.LayoutParams.staticClass, global::android.widget.RelativeLayout.LayoutParams._LayoutParams11378, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams11379;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.RelativeLayout.LayoutParams.staticClass, global::android.widget.RelativeLayout.LayoutParams._LayoutParams11379, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams11380;
			public LayoutParams(android.view.ViewGroup.MarginLayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.RelativeLayout.LayoutParams.staticClass, global::android.widget.RelativeLayout.LayoutParams._LayoutParams11380, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.FieldId _alignWithParent11381;
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
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.RelativeLayout.LayoutParams.staticClass = @__class;
				global::android.widget.RelativeLayout.LayoutParams._debug11373 = @__env.GetMethodID(global::android.widget.RelativeLayout.LayoutParams.staticClass, "debug", "(Ljava/lang/String;)Ljava/lang/String;");
				global::android.widget.RelativeLayout.LayoutParams._addRule11374 = @__env.GetMethodID(global::android.widget.RelativeLayout.LayoutParams.staticClass, "addRule", "(I)V");
				global::android.widget.RelativeLayout.LayoutParams._addRule11375 = @__env.GetMethodID(global::android.widget.RelativeLayout.LayoutParams.staticClass, "addRule", "(II)V");
				global::android.widget.RelativeLayout.LayoutParams._getRules11376 = @__env.GetMethodID(global::android.widget.RelativeLayout.LayoutParams.staticClass, "getRules", "()[I");
				global::android.widget.RelativeLayout.LayoutParams._LayoutParams11377 = @__env.GetMethodID(global::android.widget.RelativeLayout.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.widget.RelativeLayout.LayoutParams._LayoutParams11378 = @__env.GetMethodID(global::android.widget.RelativeLayout.LayoutParams.staticClass, "<init>", "(II)V");
				global::android.widget.RelativeLayout.LayoutParams._LayoutParams11379 = @__env.GetMethodID(global::android.widget.RelativeLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::android.widget.RelativeLayout.LayoutParams._LayoutParams11380 = @__env.GetMethodID(global::android.widget.RelativeLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchPopulateAccessibilityEvent11382;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.RelativeLayout._dispatchPopulateAccessibilityEvent11382, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._dispatchPopulateAccessibilityEvent11382, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setGravity11383;
		public virtual void setGravity(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RelativeLayout._setGravity11383, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._setGravity11383, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onLayout11384;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RelativeLayout._onLayout11384, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._onLayout11384, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBaseline11385;
		public override int getBaseline() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.widget.RelativeLayout._getBaseline11385);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._getBaseline11385);
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestLayout11386;
		public override void requestLayout() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RelativeLayout._requestLayout11386);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._requestLayout11386);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure11387;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RelativeLayout._onMeasure11387, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._onMeasure11387, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkLayoutParams11388;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.RelativeLayout._checkLayoutParams11388, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._checkLayoutParams11388, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams11389;
		public virtual new global::android.widget.RelativeLayout.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.RelativeLayout.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.RelativeLayout._generateLayoutParams11389, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.RelativeLayout.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._generateLayoutParams11389, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams11390;
		protected override global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.RelativeLayout._generateLayoutParams11390, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._generateLayoutParams11390, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _generateDefaultLayoutParams11391;
		protected override global::android.view.ViewGroup.LayoutParams generateDefaultLayoutParams() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.RelativeLayout._generateDefaultLayoutParams11391));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._generateDefaultLayoutParams11391));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setHorizontalGravity11392;
		public virtual void setHorizontalGravity(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RelativeLayout._setHorizontalGravity11392, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._setHorizontalGravity11392, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVerticalGravity11393;
		public virtual void setVerticalGravity(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RelativeLayout._setVerticalGravity11393, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._setVerticalGravity11393, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setIgnoreGravity11394;
		public virtual void setIgnoreGravity(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.RelativeLayout._setIgnoreGravity11394, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._setIgnoreGravity11394, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _RelativeLayout11395;
		public RelativeLayout(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._RelativeLayout11395, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _RelativeLayout11396;
		public RelativeLayout(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._RelativeLayout11396, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _RelativeLayout11397;
		public RelativeLayout(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.RelativeLayout.staticClass, global::android.widget.RelativeLayout._RelativeLayout11397, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.RelativeLayout.staticClass = @__class;
			global::android.widget.RelativeLayout._dispatchPopulateAccessibilityEvent11382 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.widget.RelativeLayout._setGravity11383 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "setGravity", "(I)V");
			global::android.widget.RelativeLayout._onLayout11384 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.RelativeLayout._getBaseline11385 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "getBaseline", "()I");
			global::android.widget.RelativeLayout._requestLayout11386 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "requestLayout", "()V");
			global::android.widget.RelativeLayout._onMeasure11387 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "onMeasure", "(II)V");
			global::android.widget.RelativeLayout._checkLayoutParams11388 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z");
			global::android.widget.RelativeLayout._generateLayoutParams11389 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/RelativeLayout$LayoutParams;");
			global::android.widget.RelativeLayout._generateLayoutParams11390 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;");
			global::android.widget.RelativeLayout._generateDefaultLayoutParams11391 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;");
			global::android.widget.RelativeLayout._setHorizontalGravity11392 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "setHorizontalGravity", "(I)V");
			global::android.widget.RelativeLayout._setVerticalGravity11393 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "setVerticalGravity", "(I)V");
			global::android.widget.RelativeLayout._setIgnoreGravity11394 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "setIgnoreGravity", "(I)V");
			global::android.widget.RelativeLayout._RelativeLayout11395 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.RelativeLayout._RelativeLayout11396 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.RelativeLayout._RelativeLayout11397 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}
