namespace android.widget 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class TableRow : android.widget.LinearLayout
	{ 
		internal new static global::java.lang.Class staticClass; 
		static TableRow() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.TableRow), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.widget.TableRow(@__env); 
			} 
		} 
		protected TableRow(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public new class LayoutParams : android.widget.LinearLayout.LayoutParams
		{ 
			internal new static global::java.lang.Class staticClass; 
			static LayoutParams() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.widget.TableRow.LayoutParams), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.widget.TableRow.LayoutParams(@__env); 
				} 
			} 
			protected LayoutParams(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setBaseAttributes10186; 
			protected override void setBaseAttributes(android.content.res.TypedArray arg0, int arg1, int arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.widget.TableRow.LayoutParams)) 
					@__env.CallVoidMethod(this, _setBaseAttributes10186, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.widget.TableRow.LayoutParams.staticClass, _setBaseAttributes10186, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10187; 
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.TableRow.LayoutParams.staticClass, _LayoutParams10187, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10188; 
			public LayoutParams(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.TableRow.LayoutParams.staticClass, _LayoutParams10188, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10189; 
			public LayoutParams(int arg0, int arg1, float arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.TableRow.LayoutParams.staticClass, _LayoutParams10189, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10190; 
			public LayoutParams()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.TableRow.LayoutParams.staticClass, _LayoutParams10190, this); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10191; 
			public LayoutParams(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.TableRow.LayoutParams.staticClass, _LayoutParams10191, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10192; 
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.TableRow.LayoutParams.staticClass, _LayoutParams10192, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10193; 
			public LayoutParams(android.view.ViewGroup.MarginLayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.widget.TableRow.LayoutParams.staticClass, _LayoutParams10193, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _column10194; 
			public int column
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _span10195; 
			public int span
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
				global::android.widget.TableRow.LayoutParams.staticClass = @__class; 
				global::android.widget.TableRow.LayoutParams._setBaseAttributes10186 = @__env.GetMethodID(global::android.widget.TableRow.LayoutParams.staticClass, "setBaseAttributes", "(Landroid/content/res/TypedArray;II)V"); 
				global::android.widget.TableRow.LayoutParams._LayoutParams10187 = @__env.GetMethodID(global::android.widget.TableRow.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
				global::android.widget.TableRow.LayoutParams._LayoutParams10188 = @__env.GetMethodID(global::android.widget.TableRow.LayoutParams.staticClass, "<init>", "(II)V"); 
				global::android.widget.TableRow.LayoutParams._LayoutParams10189 = @__env.GetMethodID(global::android.widget.TableRow.LayoutParams.staticClass, "<init>", "(IIF)V"); 
				global::android.widget.TableRow.LayoutParams._LayoutParams10190 = @__env.GetMethodID(global::android.widget.TableRow.LayoutParams.staticClass, "<init>", "()V"); 
				global::android.widget.TableRow.LayoutParams._LayoutParams10191 = @__env.GetMethodID(global::android.widget.TableRow.LayoutParams.staticClass, "<init>", "(I)V"); 
				global::android.widget.TableRow.LayoutParams._LayoutParams10192 = @__env.GetMethodID(global::android.widget.TableRow.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V"); 
				global::android.widget.TableRow.LayoutParams._LayoutParams10193 = @__env.GetMethodID(global::android.widget.TableRow.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLayout10196; 
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TableRow)) 
				@__env.CallVoidMethod(this, _onLayout10196, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TableRow.staticClass, _onLayout10196, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure10197; 
		protected override void onMeasure(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TableRow)) 
				@__env.CallVoidMethod(this, _onMeasure10197, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TableRow.staticClass, _onMeasure10197, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkLayoutParams10198; 
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TableRow)) 
				return @__env.CallBooleanMethod(this, _checkLayoutParams10198, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.widget.TableRow.staticClass, _checkLayoutParams10198, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnHierarchyChangeListener10199; 
		public override void setOnHierarchyChangeListener(android.view.ViewGroup.OnHierarchyChangeListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TableRow)) 
				@__env.CallVoidMethod(this, _setOnHierarchyChangeListener10199, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.widget.TableRow.staticClass, _setOnHierarchyChangeListener10199, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams10200; 
		public virtual new android.widget.TableRow.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TableRow)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TableRow.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, _generateLayoutParams10200, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TableRow.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TableRow.staticClass, _generateLayoutParams10200, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams10201; 
		protected override android.widget.LinearLayout.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TableRow)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.LinearLayout.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, _generateLayoutParams10201, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.LinearLayout.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TableRow.staticClass, _generateLayoutParams10201, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _generateDefaultLayoutParams10202; 
		protected override android.widget.LinearLayout.LayoutParams generateDefaultLayoutParams() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TableRow)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.LinearLayout.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, _generateDefaultLayoutParams10202)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.LinearLayout.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TableRow.staticClass, _generateDefaultLayoutParams10202)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVirtualChildAt10203; 
		public virtual android.view.View getVirtualChildAt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TableRow)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallObjectMethodPtr(this, _getVirtualChildAt10203, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.View>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.widget.TableRow.staticClass, _getVirtualChildAt10203, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVirtualChildCount10204; 
		public virtual int getVirtualChildCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.widget.TableRow)) 
				return @__env.CallIntMethod(this, _getVirtualChildCount10204); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.widget.TableRow.staticClass, _getVirtualChildCount10204); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TableRow10205; 
		public TableRow(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.TableRow.staticClass, _TableRow10205, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TableRow10206; 
		public TableRow(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.widget.TableRow.staticClass, _TableRow10206, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.widget.TableRow.staticClass = @__class; 
			global::android.widget.TableRow._onLayout10196 = @__env.GetMethodID(global::android.widget.TableRow.staticClass, "onLayout", "(ZIIII)V"); 
			global::android.widget.TableRow._onMeasure10197 = @__env.GetMethodID(global::android.widget.TableRow.staticClass, "onMeasure", "(II)V"); 
			global::android.widget.TableRow._checkLayoutParams10198 = @__env.GetMethodID(global::android.widget.TableRow.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z"); 
			global::android.widget.TableRow._setOnHierarchyChangeListener10199 = @__env.GetMethodID(global::android.widget.TableRow.staticClass, "setOnHierarchyChangeListener", "(Landroid/view/ViewGroup$OnHierarchyChangeListener;)V"); 
			global::android.widget.TableRow._generateLayoutParams10200 = @__env.GetMethodID(global::android.widget.TableRow.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/TableRow$LayoutParams;"); 
			global::android.widget.TableRow._generateLayoutParams10201 = @__env.GetMethodID(global::android.widget.TableRow.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/widget/LinearLayout$LayoutParams;"); 
			global::android.widget.TableRow._generateDefaultLayoutParams10202 = @__env.GetMethodID(global::android.widget.TableRow.staticClass, "generateDefaultLayoutParams", "()Landroid/widget/LinearLayout$LayoutParams;"); 
			global::android.widget.TableRow._getVirtualChildAt10203 = @__env.GetMethodID(global::android.widget.TableRow.staticClass, "getVirtualChildAt", "(I)Landroid/view/View;"); 
			global::android.widget.TableRow._getVirtualChildCount10204 = @__env.GetMethodID(global::android.widget.TableRow.staticClass, "getVirtualChildCount", "()I"); 
			global::android.widget.TableRow._TableRow10205 = @__env.GetMethodID(global::android.widget.TableRow.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
			global::android.widget.TableRow._TableRow10206 = @__env.GetMethodID(global::android.widget.TableRow.staticClass, "<init>", "(Landroid/content/Context;)V"); 
		} 
	} 
} 
