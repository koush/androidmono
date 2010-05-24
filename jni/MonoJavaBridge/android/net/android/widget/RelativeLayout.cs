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
			internal static global::net.sf.jni4net.jni.MethodId _debug10662; 
			public virtual java.lang.String debug(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.RelativeLayout.LayoutParams)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _debug10662, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.RelativeLayout.LayoutParams.staticClass, _debug10662, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _addRule10663; 
			public virtual void addRule(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.RelativeLayout.LayoutParams)) 
					@__env.CallVoidMethod(this, _addRule10663, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.widget.RelativeLayout.LayoutParams.staticClass, _addRule10663, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _addRule10664; 
			public virtual void addRule(int arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.RelativeLayout.LayoutParams)) 
					@__env.CallVoidMethod(this, _addRule10664, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.widget.RelativeLayout.LayoutParams.staticClass, _addRule10664, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getRules10665; 
			public virtual int[] getRules() 
			{ 
				if (GetType() == typeof(android.widget.RelativeLayout.LayoutParams)) 
					return null;//(@__env, @__env.CallObjectMethodPtr(this, _getRules10665)); 
				else 
					return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.RelativeLayout.LayoutParams.staticClass, _getRules10665)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10666; 
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.RelativeLayout.LayoutParams.staticClass, _LayoutParams10666, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10667; 
			public LayoutParams(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.RelativeLayout.LayoutParams.staticClass, _LayoutParams10667, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10668; 
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.RelativeLayout.LayoutParams.staticClass, _LayoutParams10668, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10669; 
			public LayoutParams(android.view.ViewGroup.MarginLayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.RelativeLayout.LayoutParams.staticClass, _LayoutParams10669, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _alignWithParent10670; 
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
				global::android.widget.RelativeLayout.LayoutParams._debug10662 = @__env.GetMethodID(global::android.widget.RelativeLayout.LayoutParams.staticClass, "debug", "(Ljava/lang/String;)Ljava/lang/String;"); 
				global::android.widget.RelativeLayout.LayoutParams._addRule10663 = @__env.GetMethodID(global::android.widget.RelativeLayout.LayoutParams.staticClass, "addRule", "(I)V"); 
				global::android.widget.RelativeLayout.LayoutParams._addRule10664 = @__env.GetMethodID(global::android.widget.RelativeLayout.LayoutParams.staticClass, "addRule", "(II)V"); 
				global::android.widget.RelativeLayout.LayoutParams._getRules10665 = @__env.GetMethodID(global::android.widget.RelativeLayout.LayoutParams.staticClass, "getRules", "()[I"); 
				global::android.widget.RelativeLayout.LayoutParams._LayoutParams10666 = @__env.GetMethodID(global::android.widget.RelativeLayout.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
				global::android.widget.RelativeLayout.LayoutParams._LayoutParams10667 = @__env.GetMethodID(global::android.widget.RelativeLayout.LayoutParams.staticClass, "<init>", "(II)V"); 
				global::android.widget.RelativeLayout.LayoutParams._LayoutParams10668 = @__env.GetMethodID(global::android.widget.RelativeLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V"); 
				global::android.widget.RelativeLayout.LayoutParams._LayoutParams10669 = @__env.GetMethodID(global::android.widget.RelativeLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dispatchPopulateAccessibilityEvent10671; 
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RelativeLayout)) 
				return @__env.CallBooleanMethod(this, _dispatchPopulateAccessibilityEvent10671, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.RelativeLayout.staticClass, _dispatchPopulateAccessibilityEvent10671, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGravity10672; 
		public virtual void setGravity(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RelativeLayout)) 
				@__env.CallVoidMethod(this, _setGravity10672, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RelativeLayout.staticClass, _setGravity10672, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLayout10673; 
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RelativeLayout)) 
				@__env.CallVoidMethod(this, _onLayout10673, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RelativeLayout.staticClass, _onLayout10673, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBaseline10674; 
		public override int getBaseline() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RelativeLayout)) 
				return @__env.CallIntMethod(this, _getBaseline10674); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.RelativeLayout.staticClass, _getBaseline10674); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestLayout10675; 
		public override void requestLayout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RelativeLayout)) 
				@__env.CallVoidMethod(this, _requestLayout10675); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RelativeLayout.staticClass, _requestLayout10675); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure10676; 
		protected override void onMeasure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RelativeLayout)) 
				@__env.CallVoidMethod(this, _onMeasure10676, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RelativeLayout.staticClass, _onMeasure10676, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkLayoutParams10677; 
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RelativeLayout)) 
				return @__env.CallBooleanMethod(this, _checkLayoutParams10677, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.RelativeLayout.staticClass, _checkLayoutParams10677, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams10678; 
		public virtual new android.widget.RelativeLayout.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RelativeLayout)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.RelativeLayout.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, _generateLayoutParams10678, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.RelativeLayout.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.RelativeLayout.staticClass, _generateLayoutParams10678, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams10679; 
		protected override android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RelativeLayout)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, _generateLayoutParams10679, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.RelativeLayout.staticClass, _generateLayoutParams10679, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateDefaultLayoutParams10680; 
		protected override android.view.ViewGroup.LayoutParams generateDefaultLayoutParams() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RelativeLayout)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, _generateDefaultLayoutParams10680)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewGroup.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.RelativeLayout.staticClass, _generateDefaultLayoutParams10680)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHorizontalGravity10681; 
		public virtual void setHorizontalGravity(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RelativeLayout)) 
				@__env.CallVoidMethod(this, _setHorizontalGravity10681, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RelativeLayout.staticClass, _setHorizontalGravity10681, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVerticalGravity10682; 
		public virtual void setVerticalGravity(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RelativeLayout)) 
				@__env.CallVoidMethod(this, _setVerticalGravity10682, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RelativeLayout.staticClass, _setVerticalGravity10682, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIgnoreGravity10683; 
		public virtual void setIgnoreGravity(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RelativeLayout)) 
				@__env.CallVoidMethod(this, _setIgnoreGravity10683, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RelativeLayout.staticClass, _setIgnoreGravity10683, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RelativeLayout10684; 
		public RelativeLayout(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.RelativeLayout.staticClass, _RelativeLayout10684, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RelativeLayout10685; 
		public RelativeLayout(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.RelativeLayout.staticClass, _RelativeLayout10685, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RelativeLayout10686; 
		public RelativeLayout(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.RelativeLayout.staticClass, _RelativeLayout10686, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
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
			global::android.widget.RelativeLayout._dispatchPopulateAccessibilityEvent10671 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z"); 
			global::android.widget.RelativeLayout._setGravity10672 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "setGravity", "(I)V"); 
			global::android.widget.RelativeLayout._onLayout10673 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "onLayout", "(ZIIII)V"); 
			global::android.widget.RelativeLayout._getBaseline10674 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "getBaseline", "()I"); 
			global::android.widget.RelativeLayout._requestLayout10675 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "requestLayout", "()V"); 
			global::android.widget.RelativeLayout._onMeasure10676 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "onMeasure", "(II)V"); 
			global::android.widget.RelativeLayout._checkLayoutParams10677 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z"); 
			global::android.widget.RelativeLayout._generateLayoutParams10678 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/RelativeLayout$LayoutParams;"); 
			global::android.widget.RelativeLayout._generateLayoutParams10679 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;"); 
			global::android.widget.RelativeLayout._generateDefaultLayoutParams10680 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;"); 
			global::android.widget.RelativeLayout._setHorizontalGravity10681 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "setHorizontalGravity", "(I)V"); 
			global::android.widget.RelativeLayout._setVerticalGravity10682 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "setVerticalGravity", "(I)V"); 
			global::android.widget.RelativeLayout._setIgnoreGravity10683 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "setIgnoreGravity", "(I)V"); 
			global::android.widget.RelativeLayout._RelativeLayout10684 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.RelativeLayout._RelativeLayout10685 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.RelativeLayout._RelativeLayout10686 = @__env.GetMethodID(global::android.widget.RelativeLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V"); 
		} 
	} 
} 
