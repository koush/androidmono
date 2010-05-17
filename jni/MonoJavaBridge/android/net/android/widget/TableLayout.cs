namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class TableLayout : android.widget.LinearLayout
	{ 
		internal new static global::java.lang.Class staticClass; 
		static TableLayout() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.TableLayout), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.TableLayout(@__env); 
			} 
		} 
		protected TableLayout(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public new class LayoutParams : android.widget.LinearLayout.LayoutParams
		{ 
			internal new static global::java.lang.Class staticClass; 
			static LayoutParams() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.TableLayout.LayoutParams), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.widget.TableLayout.LayoutParams(@__env); 
				} 
			} 
			protected LayoutParams(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setBaseAttributes10155; 
			protected override void setBaseAttributes(android.content.res.TypedArray arg0, int arg1, int arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.TableLayout.LayoutParams)) 
					@__env.CallVoidMethod(this, _setBaseAttributes10155, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.widget.TableLayout.LayoutParams.staticClass, _setBaseAttributes10155, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10156; 
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.TableLayout.LayoutParams.staticClass, _LayoutParams10156, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10157; 
			public LayoutParams(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.TableLayout.LayoutParams.staticClass, _LayoutParams10157, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10158; 
			public LayoutParams(int arg0, int arg1, float arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.TableLayout.LayoutParams.staticClass, _LayoutParams10158, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10159; 
			public LayoutParams()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.TableLayout.LayoutParams.staticClass, _LayoutParams10159, this); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10160; 
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.TableLayout.LayoutParams.staticClass, _LayoutParams10160, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10161; 
			public LayoutParams(android.view.ViewGroup.MarginLayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.TableLayout.LayoutParams.staticClass, _LayoutParams10161, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.widget.TableLayout.LayoutParams.staticClass = @__class; 
				global::android.widget.TableLayout.LayoutParams._setBaseAttributes10155 = @__env.GetMethodID(global::android.widget.TableLayout.LayoutParams.staticClass, "setBaseAttributes", "(Landroid/content/res/TypedArray;II)V"); 
				global::android.widget.TableLayout.LayoutParams._LayoutParams10156 = @__env.GetMethodID(global::android.widget.TableLayout.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
				global::android.widget.TableLayout.LayoutParams._LayoutParams10157 = @__env.GetMethodID(global::android.widget.TableLayout.LayoutParams.staticClass, "<init>", "(II)V"); 
				global::android.widget.TableLayout.LayoutParams._LayoutParams10158 = @__env.GetMethodID(global::android.widget.TableLayout.LayoutParams.staticClass, "<init>", "(IIF)V"); 
				global::android.widget.TableLayout.LayoutParams._LayoutParams10159 = @__env.GetMethodID(global::android.widget.TableLayout.LayoutParams.staticClass, "<init>", "()V"); 
				global::android.widget.TableLayout.LayoutParams._LayoutParams10160 = @__env.GetMethodID(global::android.widget.TableLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V"); 
				global::android.widget.TableLayout.LayoutParams._LayoutParams10161 = @__env.GetMethodID(global::android.widget.TableLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView10162; 
		public override void addView(android.view.View arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TableLayout)) 
				@__env.CallVoidMethod(this, _addView10162, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TableLayout.staticClass, _addView10162, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView10163; 
		public override void addView(android.view.View arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TableLayout)) 
				@__env.CallVoidMethod(this, _addView10163, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TableLayout.staticClass, _addView10163, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView10164; 
		public override void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TableLayout)) 
				@__env.CallVoidMethod(this, _addView10164, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TableLayout.staticClass, _addView10164, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addView10165; 
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TableLayout)) 
				@__env.CallVoidMethod(this, _addView10165, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TableLayout.staticClass, _addView10165, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLayout10166; 
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TableLayout)) 
				@__env.CallVoidMethod(this, _onLayout10166, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TableLayout.staticClass, _onLayout10166, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestLayout10167; 
		public override void requestLayout() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TableLayout)) 
				@__env.CallVoidMethod(this, _requestLayout10167); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TableLayout.staticClass, _requestLayout10167); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure10168; 
		protected override void onMeasure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TableLayout)) 
				@__env.CallVoidMethod(this, _onMeasure10168, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TableLayout.staticClass, _onMeasure10168, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkLayoutParams10169; 
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TableLayout)) 
				return @__env.CallBooleanMethod(this, _checkLayoutParams10169, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.TableLayout.staticClass, _checkLayoutParams10169, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnHierarchyChangeListener10170; 
		public override void setOnHierarchyChangeListener(android.view.ViewGroup.OnHierarchyChangeListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TableLayout)) 
				@__env.CallVoidMethod(this, _setOnHierarchyChangeListener10170, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TableLayout.staticClass, _setOnHierarchyChangeListener10170, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams10171; 
		public virtual new android.widget.TableLayout.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TableLayout)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TableLayout.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, _generateLayoutParams10171, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TableLayout.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TableLayout.staticClass, _generateLayoutParams10171, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams10172; 
		protected override android.widget.LinearLayout.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TableLayout)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.LinearLayout.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, _generateLayoutParams10172, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.LinearLayout.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TableLayout.staticClass, _generateLayoutParams10172, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateDefaultLayoutParams10173; 
		protected override android.widget.LinearLayout.LayoutParams generateDefaultLayoutParams() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TableLayout)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.LinearLayout.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, _generateDefaultLayoutParams10173)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.LinearLayout.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TableLayout.staticClass, _generateDefaultLayoutParams10173)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isShrinkAllColumns10174; 
		public virtual bool isShrinkAllColumns() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TableLayout)) 
				return @__env.CallBooleanMethod(this, _isShrinkAllColumns10174); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.TableLayout.staticClass, _isShrinkAllColumns10174); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setShrinkAllColumns10175; 
		public virtual void setShrinkAllColumns(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TableLayout)) 
				@__env.CallVoidMethod(this, _setShrinkAllColumns10175, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TableLayout.staticClass, _setShrinkAllColumns10175, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isStretchAllColumns10176; 
		public virtual bool isStretchAllColumns() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TableLayout)) 
				return @__env.CallBooleanMethod(this, _isStretchAllColumns10176); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.TableLayout.staticClass, _isStretchAllColumns10176); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStretchAllColumns10177; 
		public virtual void setStretchAllColumns(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TableLayout)) 
				@__env.CallVoidMethod(this, _setStretchAllColumns10177, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TableLayout.staticClass, _setStretchAllColumns10177, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setColumnCollapsed10178; 
		public virtual void setColumnCollapsed(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TableLayout)) 
				@__env.CallVoidMethod(this, _setColumnCollapsed10178, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TableLayout.staticClass, _setColumnCollapsed10178, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isColumnCollapsed10179; 
		public virtual bool isColumnCollapsed(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TableLayout)) 
				return @__env.CallBooleanMethod(this, _isColumnCollapsed10179, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.TableLayout.staticClass, _isColumnCollapsed10179, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setColumnStretchable10180; 
		public virtual void setColumnStretchable(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TableLayout)) 
				@__env.CallVoidMethod(this, _setColumnStretchable10180, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TableLayout.staticClass, _setColumnStretchable10180, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isColumnStretchable10181; 
		public virtual bool isColumnStretchable(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TableLayout)) 
				return @__env.CallBooleanMethod(this, _isColumnStretchable10181, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.TableLayout.staticClass, _isColumnStretchable10181, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setColumnShrinkable10182; 
		public virtual void setColumnShrinkable(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TableLayout)) 
				@__env.CallVoidMethod(this, _setColumnShrinkable10182, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TableLayout.staticClass, _setColumnShrinkable10182, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isColumnShrinkable10183; 
		public virtual bool isColumnShrinkable(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TableLayout)) 
				return @__env.CallBooleanMethod(this, _isColumnShrinkable10183, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.TableLayout.staticClass, _isColumnShrinkable10183, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TableLayout10184; 
		public TableLayout(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.TableLayout.staticClass, _TableLayout10184, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TableLayout10185; 
		public TableLayout(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.TableLayout.staticClass, _TableLayout10185, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.TableLayout.staticClass = @__class; 
			global::android.widget.TableLayout._addView10162 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "addView", "(Landroid/view/View;)V"); 
			global::android.widget.TableLayout._addView10163 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "addView", "(Landroid/view/View;I)V"); 
			global::android.widget.TableLayout._addView10164 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.widget.TableLayout._addView10165 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V"); 
			global::android.widget.TableLayout._onLayout10166 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "onLayout", "(ZIIII)V"); 
			global::android.widget.TableLayout._requestLayout10167 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "requestLayout", "()V"); 
			global::android.widget.TableLayout._onMeasure10168 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "onMeasure", "(II)V"); 
			global::android.widget.TableLayout._checkLayoutParams10169 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z"); 
			global::android.widget.TableLayout._setOnHierarchyChangeListener10170 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "setOnHierarchyChangeListener", "(Landroid/view/ViewGroup$OnHierarchyChangeListener;)V"); 
			global::android.widget.TableLayout._generateLayoutParams10171 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/TableLayout$LayoutParams;"); 
			global::android.widget.TableLayout._generateLayoutParams10172 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/widget/LinearLayout$LayoutParams;"); 
			global::android.widget.TableLayout._generateDefaultLayoutParams10173 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "generateDefaultLayoutParams", "()Landroid/widget/LinearLayout$LayoutParams;"); 
			global::android.widget.TableLayout._isShrinkAllColumns10174 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "isShrinkAllColumns", "()Z"); 
			global::android.widget.TableLayout._setShrinkAllColumns10175 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "setShrinkAllColumns", "(Z)V"); 
			global::android.widget.TableLayout._isStretchAllColumns10176 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "isStretchAllColumns", "()Z"); 
			global::android.widget.TableLayout._setStretchAllColumns10177 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "setStretchAllColumns", "(Z)V"); 
			global::android.widget.TableLayout._setColumnCollapsed10178 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "setColumnCollapsed", "(IZ)V"); 
			global::android.widget.TableLayout._isColumnCollapsed10179 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "isColumnCollapsed", "(I)Z"); 
			global::android.widget.TableLayout._setColumnStretchable10180 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "setColumnStretchable", "(IZ)V"); 
			global::android.widget.TableLayout._isColumnStretchable10181 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "isColumnStretchable", "(I)Z"); 
			global::android.widget.TableLayout._setColumnShrinkable10182 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "setColumnShrinkable", "(IZ)V"); 
			global::android.widget.TableLayout._isColumnShrinkable10183 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "isColumnShrinkable", "(I)Z"); 
			global::android.widget.TableLayout._TableLayout10184 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.widget.TableLayout._TableLayout10185 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
		} 
	} 
} 
