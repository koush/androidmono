namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class RelativeLayout : android.view.ViewGroup
	{ 
		internal new static global::java.lang.Class staticClass; 
		static RelativeLayout() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.RelativeLayout), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.RelativeLayout.LayoutParams), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _debug9890; 
			public virtual java.lang.String debug(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.RelativeLayout.LayoutParams)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _debug9890, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.RelativeLayout.LayoutParams.staticClass, _debug9890, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _addRule9891; 
			public virtual void addRule(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.RelativeLayout.LayoutParams)) 
					@__env.CallVoidMethod(this, _addRule9891, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.widget.RelativeLayout.LayoutParams.staticClass, _addRule9891, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _addRule9892; 
			public virtual void addRule(int arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.RelativeLayout.LayoutParams)) 
					@__env.CallVoidMethod(this, _addRule9892, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.widget.RelativeLayout.LayoutParams.staticClass, _addRule9892, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getRules9893; 
			public virtual int[] getRules() 
			{ 
				if (GetType() == typeof(android.widget.RelativeLayout.LayoutParams)) 
					return null;//(@__env, @__env.CallObjectMethodPtr(this, _getRules9893)); 
				else 
					return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.RelativeLayout.LayoutParams.staticClass, _getRules9893)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams9894; 
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.RelativeLayout.LayoutParams.staticClass, _LayoutParams9894, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams9895; 
			public LayoutParams(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.RelativeLayout.LayoutParams.staticClass, _LayoutParams9895, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams9896; 
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.RelativeLayout.LayoutParams.staticClass, _LayoutParams9896, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams9897; 
			public LayoutParams(android.view.ViewGroup.MarginLayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.RelativeLayout.LayoutParams.staticClass, _LayoutParams9897, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _alignWithParent9898; 
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
				global::android.widget.RelativeLayout.LayoutParams._debug9890 = @__env.GetMethodID(global::android.widget.RelativeLayout.LayoutParams.staticClass, "debug", "(Ljava/lang/String;)Ljava/lang/String;"); 
				global::android.widget.RelativeLayout.LayoutParams._addRule9891 = @__env.GetMethodID(global::android.widget.RelativeLayout.LayoutParams.staticClass, "addRule", "(I)V"); 
				global::android.widget.RelativeLayout.LayoutParams._addRule9892 = @__env.GetMethodID(global::android.widget.RelativeLayout.LayoutParams.staticClass, "addRule", "(II)V"); 
				global::android.widget.RelativeLayout.LayoutParams._getRules9893 = @__env.GetMethodID(global::android.widget.RelativeLayout.LayoutParams.staticClass, "getRules", "()[I"); 
				global::android.widget.RelativeLayout.LayoutParams._LayoutParams9894 = @__env.GetMethodID(global::android.widget.RelativeLayout.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
				global::android.widget.RelativeLayout.LayoutParams._LayoutParams9895 = @__env.GetMethodID(global::android.widget.RelativeLayout.LayoutParams.staticClass, "<init>", "(II)V"); 
				global::android.widget.RelativeLayout.LayoutParams._LayoutParams9896 = @__env.GetMethodID(global::android.widget.RelativeLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V"); 
				global::android.widget.RelativeLayout.LayoutParams._LayoutParams9897 = @__env.GetMethodID(global::android.widget.RelativeLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchPopulateAccessibilityEvent9899; 
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RelativeLayout)) 
				return @__env.CallBooleanMethod(this, _dispatchPopulateAccessibilityEvent9899, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.RelativeLayout.staticClass, _dispatchPopulateAccessibilityEvent9899, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGravity9900; 
		public virtual void setGravity(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RelativeLayout)) 
				@__env.CallVoidMethod(this, _setGravity9900, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RelativeLayout.staticClass, _setGravity9900, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLayout9901; 
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RelativeLayout)) 
				@__env.CallVoidMethod(this, _onLayout9901, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RelativeLayout.staticClass, _onLayout9901, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBaseline9902; 
		public override int getBaseline() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RelativeLayout)) 
				return @__env.CallIntMethod(this, _getBaseline9902); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.RelativeLayout.staticClass, _getBaseline9902); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestLayout9903; 
		public override void requestLayout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RelativeLayout)) 
				@__env.CallVoidMethod(this, _requestLayout9903); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RelativeLayout.staticClass, _requestLayout9903); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure9904; 
		protected override void onMeasure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RelativeLayout)) 
				@__env.CallVoidMethod(this, _onMeasure9904, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RelativeLayout.staticClass, _onMeasure9904, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkLayoutParams9905; 
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RelativeLayout)) 
				return @__env.CallBooleanMethod(this, _checkLayoutParams9905, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.RelativeLayout.staticClass, _checkLayoutParams9905, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams9906; 
		public virtual new android.widget.RelativeLayout.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RelativeLayout)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.RelativeLayout.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, _generateLayoutParams9906, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.RelativeLayout.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.RelativeLayout.staticClass, _generateLayoutParams9906, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams9907; 
		protected override android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RelativeLayout)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, _generateLayoutParams9907, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.RelativeLayout.staticClass, _generateLayoutParams9907, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateDefaultLayoutParams9908; 
		protected override android.view.ViewGroup.LayoutParams generateDefaultLayoutParams() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RelativeLayout)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, _generateDefaultLayoutParams9908)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.RelativeLayout.staticClass, _generateDefaultLayoutParams9908)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHorizontalGravity9909; 
		public virtual void setHorizontalGravity(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RelativeLayout)) 
				@__env.CallVoidMethod(this, _setHorizontalGravity9909, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RelativeLayout.staticClass, _setHorizontalGravity9909, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVerticalGravity9910; 
		public virtual void setVerticalGravity(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RelativeLayout)) 
				@__env.CallVoidMethod(this, _setVerticalGravity9910, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RelativeLayout.staticClass, _setVerticalGravity9910, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIgnoreGravity9911; 
		public virtual void setIgnoreGravity(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RelativeLayout)) 
				@__env.CallVoidMethod(this, _setIgnoreGravity9911, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RelativeLayout.staticClass, _setIgnoreGravity9911, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RelativeLayout9912; 
		public RelativeLayout(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.RelativeLayout.staticClass, _RelativeLayout9912, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RelativeLayout9913; 
		public RelativeLayout(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.RelativeLayout.staticClass, _RelativeLayout9913, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RelativeLayout9914; 
		public RelativeLayout(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.RelativeLayout.staticClass, _RelativeLayout9914, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
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
			global::android.widget.RelativeLayout._dispatchPopulateAccessibilityEvent9899 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z"); 
			global::android.widget.RelativeLayout._setGravity9900 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "setGravity", "(I)V"); 
			global::android.widget.RelativeLayout._onLayout9901 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "onLayout", "(ZIIII)V"); 
			global::android.widget.RelativeLayout._getBaseline9902 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "getBaseline", "()I"); 
			global::android.widget.RelativeLayout._requestLayout9903 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "requestLayout", "()V"); 
			global::android.widget.RelativeLayout._onMeasure9904 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "onMeasure", "(II)V"); 
			global::android.widget.RelativeLayout._checkLayoutParams9905 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z"); 
			global::android.widget.RelativeLayout._generateLayoutParams9906 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/RelativeLayout$LayoutParams;"); 
			global::android.widget.RelativeLayout._generateLayoutParams9907 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;"); 
			global::android.widget.RelativeLayout._generateDefaultLayoutParams9908 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;"); 
			global::android.widget.RelativeLayout._setHorizontalGravity9909 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "setHorizontalGravity", "(I)V"); 
			global::android.widget.RelativeLayout._setVerticalGravity9910 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "setVerticalGravity", "(I)V"); 
			global::android.widget.RelativeLayout._setIgnoreGravity9911 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "setIgnoreGravity", "(I)V"); 
			global::android.widget.RelativeLayout._RelativeLayout9912 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.RelativeLayout._RelativeLayout9913 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.RelativeLayout._RelativeLayout9914 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
