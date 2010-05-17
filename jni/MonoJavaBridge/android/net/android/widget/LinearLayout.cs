namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class LinearLayout : android.view.ViewGroup
	{ 
		internal new static global::java.lang.Class staticClass; 
		static LinearLayout() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.LinearLayout), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.LinearLayout(@__env); 
			} 
		} 
		protected LinearLayout(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public new class LayoutParams : android.view.ViewGroup.MarginLayoutParams
		{ 
			internal new static global::java.lang.Class staticClass; 
			static LayoutParams() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.LinearLayout.LayoutParams), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.widget.LinearLayout.LayoutParams(@__env); 
				} 
			} 
			protected LayoutParams(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _debug9653; 
			public virtual java.lang.String debug(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.LinearLayout.LayoutParams)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _debug9653, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.LinearLayout.LayoutParams.staticClass, _debug9653, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams9654; 
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.LinearLayout.LayoutParams.staticClass, _LayoutParams9654, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams9655; 
			public LayoutParams(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.LinearLayout.LayoutParams.staticClass, _LayoutParams9655, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams9656; 
			public LayoutParams(int arg0, int arg1, float arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.LinearLayout.LayoutParams.staticClass, _LayoutParams9656, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams9657; 
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.LinearLayout.LayoutParams.staticClass, _LayoutParams9657, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams9658; 
			public LayoutParams(android.view.ViewGroup.MarginLayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.LinearLayout.LayoutParams.staticClass, _LayoutParams9658, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _weight9659; 
			public float weight
			{ 
				get 
				{ 
					return default(float); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _gravity9660; 
			public int gravity
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.widget.LinearLayout.LayoutParams.staticClass = @__class; 
				global::android.widget.LinearLayout.LayoutParams._debug9653 = @__env.GetMethodID(global::android.widget.LinearLayout.LayoutParams.staticClass, "debug", "(Ljava/lang/String;)Ljava/lang/String;"); 
				global::android.widget.LinearLayout.LayoutParams._LayoutParams9654 = @__env.GetMethodID(global::android.widget.LinearLayout.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
				global::android.widget.LinearLayout.LayoutParams._LayoutParams9655 = @__env.GetMethodID(global::android.widget.LinearLayout.LayoutParams.staticClass, "<init>", "(II)V"); 
				global::android.widget.LinearLayout.LayoutParams._LayoutParams9656 = @__env.GetMethodID(global::android.widget.LinearLayout.LayoutParams.staticClass, "<init>", "(IIF)V"); 
				global::android.widget.LinearLayout.LayoutParams._LayoutParams9657 = @__env.GetMethodID(global::android.widget.LinearLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V"); 
				global::android.widget.LinearLayout.LayoutParams._LayoutParams9658 = @__env.GetMethodID(global::android.widget.LinearLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGravity9661; 
		public virtual void setGravity(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.LinearLayout)) 
				@__env.CallVoidMethod(this, _setGravity9661, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.LinearLayout.staticClass, _setGravity9661, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLayout9662; 
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.LinearLayout)) 
				@__env.CallVoidMethod(this, _onLayout9662, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.LinearLayout.staticClass, _onLayout9662, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBaseline9663; 
		public override int getBaseline() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.LinearLayout)) 
				return @__env.CallIntMethod(this, _getBaseline9663); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.LinearLayout.staticClass, _getBaseline9663); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure9664; 
		protected override void onMeasure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.LinearLayout)) 
				@__env.CallVoidMethod(this, _onMeasure9664, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.LinearLayout.staticClass, _onMeasure9664, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkLayoutParams9665; 
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.LinearLayout)) 
				return @__env.CallBooleanMethod(this, _checkLayoutParams9665, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.LinearLayout.staticClass, _checkLayoutParams9665, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams9666; 
		public virtual new android.widget.LinearLayout.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.LinearLayout)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.LinearLayout.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, _generateLayoutParams9666, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.LinearLayout.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.LinearLayout.staticClass, _generateLayoutParams9666, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams9667; 
		protected virtual new android.widget.LinearLayout.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.LinearLayout)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.LinearLayout.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, _generateLayoutParams9667, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.LinearLayout.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.LinearLayout.staticClass, _generateLayoutParams9667, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateDefaultLayoutParams9668; 
		protected virtual new android.widget.LinearLayout.LayoutParams generateDefaultLayoutParams() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.LinearLayout)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.LinearLayout.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, _generateDefaultLayoutParams9668)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.LinearLayout.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.LinearLayout.staticClass, _generateDefaultLayoutParams9668)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isBaselineAligned9669; 
		public virtual bool isBaselineAligned() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.LinearLayout)) 
				return @__env.CallBooleanMethod(this, _isBaselineAligned9669); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.LinearLayout.staticClass, _isBaselineAligned9669); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBaselineAligned9670; 
		public virtual void setBaselineAligned(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.LinearLayout)) 
				@__env.CallVoidMethod(this, _setBaselineAligned9670, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.LinearLayout.staticClass, _setBaselineAligned9670, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBaselineAlignedChildIndex9671; 
		public virtual int getBaselineAlignedChildIndex() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.LinearLayout)) 
				return @__env.CallIntMethod(this, _getBaselineAlignedChildIndex9671); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.LinearLayout.staticClass, _getBaselineAlignedChildIndex9671); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBaselineAlignedChildIndex9672; 
		public virtual void setBaselineAlignedChildIndex(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.LinearLayout)) 
				@__env.CallVoidMethod(this, _setBaselineAlignedChildIndex9672, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.LinearLayout.staticClass, _setBaselineAlignedChildIndex9672, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWeightSum9673; 
		public virtual float getWeightSum() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.LinearLayout)) 
				return @__env.CallFloatMethod(this, _getWeightSum9673); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.widget.LinearLayout.staticClass, _getWeightSum9673); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWeightSum9674; 
		public virtual void setWeightSum(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.LinearLayout)) 
				@__env.CallVoidMethod(this, _setWeightSum9674, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.LinearLayout.staticClass, _setWeightSum9674, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOrientation9675; 
		public virtual void setOrientation(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.LinearLayout)) 
				@__env.CallVoidMethod(this, _setOrientation9675, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.LinearLayout.staticClass, _setOrientation9675, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOrientation9676; 
		public virtual int getOrientation() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.LinearLayout)) 
				return @__env.CallIntMethod(this, _getOrientation9676); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.LinearLayout.staticClass, _getOrientation9676); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setHorizontalGravity9677; 
		public virtual void setHorizontalGravity(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.LinearLayout)) 
				@__env.CallVoidMethod(this, _setHorizontalGravity9677, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.LinearLayout.staticClass, _setHorizontalGravity9677, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVerticalGravity9678; 
		public virtual void setVerticalGravity(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.LinearLayout)) 
				@__env.CallVoidMethod(this, _setVerticalGravity9678, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.LinearLayout.staticClass, _setVerticalGravity9678, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LinearLayout9679; 
		public LinearLayout(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.LinearLayout.staticClass, _LinearLayout9679, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LinearLayout9680; 
		public LinearLayout(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.LinearLayout.staticClass, _LinearLayout9680, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		public static int HORIZONTAL
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int VERTICAL
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.LinearLayout.staticClass = @__class; 
			global::android.widget.LinearLayout._setGravity9661 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "setGravity", "(I)V"); 
			global::android.widget.LinearLayout._onLayout9662 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "onLayout", "(ZIIII)V"); 
			global::android.widget.LinearLayout._getBaseline9663 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "getBaseline", "()I"); 
			global::android.widget.LinearLayout._onMeasure9664 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "onMeasure", "(II)V"); 
			global::android.widget.LinearLayout._checkLayoutParams9665 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z"); 
			global::android.widget.LinearLayout._generateLayoutParams9666 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/LinearLayout$LayoutParams;"); 
			global::android.widget.LinearLayout._generateLayoutParams9667 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/widget/LinearLayout$LayoutParams;"); 
			global::android.widget.LinearLayout._generateDefaultLayoutParams9668 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "generateDefaultLayoutParams", "()Landroid/widget/LinearLayout$LayoutParams;"); 
			global::android.widget.LinearLayout._isBaselineAligned9669 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "isBaselineAligned", "()Z"); 
			global::android.widget.LinearLayout._setBaselineAligned9670 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "setBaselineAligned", "(Z)V"); 
			global::android.widget.LinearLayout._getBaselineAlignedChildIndex9671 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "getBaselineAlignedChildIndex", "()I"); 
			global::android.widget.LinearLayout._setBaselineAlignedChildIndex9672 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "setBaselineAlignedChildIndex", "(I)V"); 
			global::android.widget.LinearLayout._getWeightSum9673 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "getWeightSum", "()F"); 
			global::android.widget.LinearLayout._setWeightSum9674 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "setWeightSum", "(F)V"); 
			global::android.widget.LinearLayout._setOrientation9675 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "setOrientation", "(I)V"); 
			global::android.widget.LinearLayout._getOrientation9676 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "getOrientation", "()I"); 
			global::android.widget.LinearLayout._setHorizontalGravity9677 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "setHorizontalGravity", "(I)V"); 
			global::android.widget.LinearLayout._setVerticalGravity9678 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "setVerticalGravity", "(I)V"); 
			global::android.widget.LinearLayout._LinearLayout9679 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.LinearLayout._LinearLayout9680 = @__env.GetMethodID(global::android.widget.LinearLayout.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
