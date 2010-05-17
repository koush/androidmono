namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class RadioGroup : android.widget.LinearLayout
	{ 
		internal new static global::java.lang.Class staticClass; 
		static RadioGroup() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.RadioGroup), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.RadioGroup(@__env); 
			} 
		} 
		protected RadioGroup(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public new class LayoutParams : android.widget.LinearLayout.LayoutParams
		{ 
			internal new static global::java.lang.Class staticClass; 
			static LayoutParams() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.RadioGroup.LayoutParams), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.widget.RadioGroup.LayoutParams(@__env); 
				} 
			} 
			protected LayoutParams(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setBaseAttributes9857; 
			protected override void setBaseAttributes(android.content.res.TypedArray arg0, int arg1, int arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.RadioGroup.LayoutParams)) 
					@__env.CallVoidMethod(this, _setBaseAttributes9857, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.widget.RadioGroup.LayoutParams.staticClass, _setBaseAttributes9857, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams9858; 
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.RadioGroup.LayoutParams.staticClass, _LayoutParams9858, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams9859; 
			public LayoutParams(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.RadioGroup.LayoutParams.staticClass, _LayoutParams9859, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams9860; 
			public LayoutParams(int arg0, int arg1, float arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.RadioGroup.LayoutParams.staticClass, _LayoutParams9860, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams9861; 
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.RadioGroup.LayoutParams.staticClass, _LayoutParams9861, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams9862; 
			public LayoutParams(android.view.ViewGroup.MarginLayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.RadioGroup.LayoutParams.staticClass, _LayoutParams9862, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.widget.RadioGroup.LayoutParams.staticClass = @__class; 
				global::android.widget.RadioGroup.LayoutParams._setBaseAttributes9857 = @__env.GetMethodID(global::android.widget.RadioGroup.LayoutParams.staticClass, "setBaseAttributes", "(Landroid/content/res/TypedArray;II)V"); 
				global::android.widget.RadioGroup.LayoutParams._LayoutParams9858 = @__env.GetMethodID(global::android.widget.RadioGroup.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
				global::android.widget.RadioGroup.LayoutParams._LayoutParams9859 = @__env.GetMethodID(global::android.widget.RadioGroup.LayoutParams.staticClass, "<init>", "(II)V"); 
				global::android.widget.RadioGroup.LayoutParams._LayoutParams9860 = @__env.GetMethodID(global::android.widget.RadioGroup.LayoutParams.staticClass, "<init>", "(IIF)V"); 
				global::android.widget.RadioGroup.LayoutParams._LayoutParams9861 = @__env.GetMethodID(global::android.widget.RadioGroup.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V"); 
				global::android.widget.RadioGroup.LayoutParams._LayoutParams9862 = @__env.GetMethodID(global::android.widget.RadioGroup.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnCheckedChangeListener 
		{ 
			void onCheckedChanged(android.widget.RadioGroup arg0, int arg1); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _check9863; 
		public virtual void check(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RadioGroup)) 
				@__env.CallVoidMethod(this, _check9863, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RadioGroup.staticClass, _check9863, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView9864; 
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RadioGroup)) 
				@__env.CallVoidMethod(this, _addView9864, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RadioGroup.staticClass, _addView9864, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onFinishInflate9865; 
		protected override void onFinishInflate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RadioGroup)) 
				@__env.CallVoidMethod(this, _onFinishInflate9865); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RadioGroup.staticClass, _onFinishInflate9865); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkLayoutParams9866; 
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RadioGroup)) 
				return @__env.CallBooleanMethod(this, _checkLayoutParams9866, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.RadioGroup.staticClass, _checkLayoutParams9866, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnHierarchyChangeListener9867; 
		public override void setOnHierarchyChangeListener(android.view.ViewGroup.OnHierarchyChangeListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RadioGroup)) 
				@__env.CallVoidMethod(this, _setOnHierarchyChangeListener9867, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RadioGroup.staticClass, _setOnHierarchyChangeListener9867, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams9868; 
		public virtual new android.widget.RadioGroup.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RadioGroup)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.RadioGroup.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, _generateLayoutParams9868, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.RadioGroup.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.RadioGroup.staticClass, _generateLayoutParams9868, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateDefaultLayoutParams9869; 
		protected override android.widget.LinearLayout.LayoutParams generateDefaultLayoutParams() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RadioGroup)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.LinearLayout.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, _generateDefaultLayoutParams9869)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.LinearLayout.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.RadioGroup.staticClass, _generateDefaultLayoutParams9869)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnCheckedChangeListener9870; 
		public virtual void setOnCheckedChangeListener(android.widget.RadioGroup.OnCheckedChangeListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RadioGroup)) 
				@__env.CallVoidMethod(this, _setOnCheckedChangeListener9870, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RadioGroup.staticClass, _setOnCheckedChangeListener9870, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCheckedRadioButtonId9871; 
		public virtual int getCheckedRadioButtonId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RadioGroup)) 
				return @__env.CallIntMethod(this, _getCheckedRadioButtonId9871); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.RadioGroup.staticClass, _getCheckedRadioButtonId9871); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearCheck9872; 
		public virtual void clearCheck() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.RadioGroup)) 
				@__env.CallVoidMethod(this, _clearCheck9872); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.RadioGroup.staticClass, _clearCheck9872); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RadioGroup9873; 
		public RadioGroup(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.RadioGroup.staticClass, _RadioGroup9873, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _RadioGroup9874; 
		public RadioGroup(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.RadioGroup.staticClass, _RadioGroup9874, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.RadioGroup.staticClass = @__class; 
			global::android.widget.RadioGroup._check9863 = @__env.GetMethodID(global::android.widget.RadioGroup.staticClass, "check", "(I)V"); 
			global::android.widget.RadioGroup._addView9864 = @__env.GetMethodID(global::android.widget.RadioGroup.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.widget.RadioGroup._onFinishInflate9865 = @__env.GetMethodID(global::android.widget.RadioGroup.staticClass, "onFinishInflate", "()V"); 
			global::android.widget.RadioGroup._checkLayoutParams9866 = @__env.GetMethodID(global::android.widget.RadioGroup.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z"); 
			global::android.widget.RadioGroup._setOnHierarchyChangeListener9867 = @__env.GetMethodID(global::android.widget.RadioGroup.staticClass, "setOnHierarchyChangeListener", "(Landroid/view/ViewGroup$OnHierarchyChangeListener;)V"); 
			global::android.widget.RadioGroup._generateLayoutParams9868 = @__env.GetMethodID(global::android.widget.RadioGroup.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/RadioGroup$LayoutParams;"); 
			global::android.widget.RadioGroup._generateDefaultLayoutParams9869 = @__env.GetMethodID(global::android.widget.RadioGroup.staticClass, "generateDefaultLayoutParams", "()Landroid/widget/LinearLayout$LayoutParams;"); 
			global::android.widget.RadioGroup._setOnCheckedChangeListener9870 = @__env.GetMethodID(global::android.widget.RadioGroup.staticClass, "setOnCheckedChangeListener", "(Landroid/widget/RadioGroup$OnCheckedChangeListener;)V"); 
			global::android.widget.RadioGroup._getCheckedRadioButtonId9871 = @__env.GetMethodID(global::android.widget.RadioGroup.staticClass, "getCheckedRadioButtonId", "()I"); 
			global::android.widget.RadioGroup._clearCheck9872 = @__env.GetMethodID(global::android.widget.RadioGroup.staticClass, "clearCheck", "()V"); 
			global::android.widget.RadioGroup._RadioGroup9873 = @__env.GetMethodID(global::android.widget.RadioGroup.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.RadioGroup._RadioGroup9874 = @__env.GetMethodID(global::android.widget.RadioGroup.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
