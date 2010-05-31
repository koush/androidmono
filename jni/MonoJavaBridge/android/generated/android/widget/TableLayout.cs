namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class TableLayout : android.widget.LinearLayout
	{
		internal new static global::java.lang.Class staticClass;
		static TableLayout()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.TableLayout), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.TableLayout.LayoutParams), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
			internal static global::net.sf.jni4net.jni.MethodId _setBaseAttributes10958;
			protected override void setBaseAttributes(android.content.res.TypedArray arg0, int arg1, int arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.widget.TableLayout.LayoutParams._setBaseAttributes10958, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.widget.TableLayout.LayoutParams.staticClass, global::android.widget.TableLayout.LayoutParams._setBaseAttributes10958, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10959;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.TableLayout.LayoutParams.staticClass, global::android.widget.TableLayout.LayoutParams._LayoutParams10959, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10960;
			public LayoutParams(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.TableLayout.LayoutParams.staticClass, global::android.widget.TableLayout.LayoutParams._LayoutParams10960, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10961;
			public LayoutParams(int arg0, int arg1, float arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.TableLayout.LayoutParams.staticClass, global::android.widget.TableLayout.LayoutParams._LayoutParams10961, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10962;
			public LayoutParams()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.TableLayout.LayoutParams.staticClass, global::android.widget.TableLayout.LayoutParams._LayoutParams10962, this);
			}
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10963;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.TableLayout.LayoutParams.staticClass, global::android.widget.TableLayout.LayoutParams._LayoutParams10963, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _LayoutParams10964;
			public LayoutParams(android.view.ViewGroup.MarginLayoutParams arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.widget.TableLayout.LayoutParams.staticClass, global::android.widget.TableLayout.LayoutParams._LayoutParams10964, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.widget.TableLayout.LayoutParams.staticClass = @__class;
				global::android.widget.TableLayout.LayoutParams._setBaseAttributes10958 = @__env.GetMethodID(global::android.widget.TableLayout.LayoutParams.staticClass, "setBaseAttributes", "(Landroid/content/res/TypedArray;II)V");
				global::android.widget.TableLayout.LayoutParams._LayoutParams10959 = @__env.GetMethodID(global::android.widget.TableLayout.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.widget.TableLayout.LayoutParams._LayoutParams10960 = @__env.GetMethodID(global::android.widget.TableLayout.LayoutParams.staticClass, "<init>", "(II)V");
				global::android.widget.TableLayout.LayoutParams._LayoutParams10961 = @__env.GetMethodID(global::android.widget.TableLayout.LayoutParams.staticClass, "<init>", "(IIF)V");
				global::android.widget.TableLayout.LayoutParams._LayoutParams10962 = @__env.GetMethodID(global::android.widget.TableLayout.LayoutParams.staticClass, "<init>", "()V");
				global::android.widget.TableLayout.LayoutParams._LayoutParams10963 = @__env.GetMethodID(global::android.widget.TableLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::android.widget.TableLayout.LayoutParams._LayoutParams10964 = @__env.GetMethodID(global::android.widget.TableLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _addView10965;
		public override void addView(android.view.View arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TableLayout._addView10965, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._addView10965, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addView10966;
		public override void addView(android.view.View arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TableLayout._addView10966, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._addView10966, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addView10967;
		public override void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TableLayout._addView10967, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._addView10967, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addView10968;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TableLayout._addView10968, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._addView10968, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onLayout10969;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TableLayout._onLayout10969, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._onLayout10969, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestLayout10970;
		public override void requestLayout() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TableLayout._requestLayout10970);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._requestLayout10970);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMeasure10971;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TableLayout._onMeasure10971, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._onMeasure10971, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _checkLayoutParams10972;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.TableLayout._checkLayoutParams10972, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._checkLayoutParams10972, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnHierarchyChangeListener10973;
		public override void setOnHierarchyChangeListener(android.view.ViewGroup.OnHierarchyChangeListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TableLayout._setOnHierarchyChangeListener10973, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._setOnHierarchyChangeListener10973, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams10974;
		public virtual new global::android.widget.TableLayout.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TableLayout.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TableLayout._generateLayoutParams10974, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.TableLayout.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._generateLayoutParams10974, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _generateLayoutParams10975;
		protected override global::android.widget.LinearLayout.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.LinearLayout.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TableLayout._generateLayoutParams10975, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.LinearLayout.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._generateLayoutParams10975, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _generateDefaultLayoutParams10976;
		protected override global::android.widget.LinearLayout.LayoutParams generateDefaultLayoutParams() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.LinearLayout.LayoutParams>(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.TableLayout._generateDefaultLayoutParams10976));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.widget.LinearLayout.LayoutParams>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._generateDefaultLayoutParams10976));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isShrinkAllColumns10977;
		public virtual bool isShrinkAllColumns() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.TableLayout._isShrinkAllColumns10977);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._isShrinkAllColumns10977);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setShrinkAllColumns10978;
		public virtual void setShrinkAllColumns(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TableLayout._setShrinkAllColumns10978, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._setShrinkAllColumns10978, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isStretchAllColumns10979;
		public virtual bool isStretchAllColumns() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.TableLayout._isStretchAllColumns10979);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._isStretchAllColumns10979);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStretchAllColumns10980;
		public virtual void setStretchAllColumns(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TableLayout._setStretchAllColumns10980, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._setStretchAllColumns10980, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setColumnCollapsed10981;
		public virtual void setColumnCollapsed(int arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TableLayout._setColumnCollapsed10981, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._setColumnCollapsed10981, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isColumnCollapsed10982;
		public virtual bool isColumnCollapsed(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.TableLayout._isColumnCollapsed10982, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._isColumnCollapsed10982, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setColumnStretchable10983;
		public virtual void setColumnStretchable(int arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TableLayout._setColumnStretchable10983, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._setColumnStretchable10983, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isColumnStretchable10984;
		public virtual bool isColumnStretchable(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.TableLayout._isColumnStretchable10984, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._isColumnStretchable10984, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setColumnShrinkable10985;
		public virtual void setColumnShrinkable(int arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.TableLayout._setColumnShrinkable10985, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._setColumnShrinkable10985, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isColumnShrinkable10986;
		public virtual bool isColumnShrinkable(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.TableLayout._isColumnShrinkable10986, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._isColumnShrinkable10986, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _TableLayout10987;
		public TableLayout(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.TableLayout.staticClass, global::android.widget.TableLayout._TableLayout10987, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _TableLayout10988;
		public TableLayout(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.TableLayout.staticClass, global::android.widget.TableLayout._TableLayout10988, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.TableLayout.staticClass = @__class;
			global::android.widget.TableLayout._addView10965 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "addView", "(Landroid/view/View;)V");
			global::android.widget.TableLayout._addView10966 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "addView", "(Landroid/view/View;I)V");
			global::android.widget.TableLayout._addView10967 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.TableLayout._addView10968 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.TableLayout._onLayout10969 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.TableLayout._requestLayout10970 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "requestLayout", "()V");
			global::android.widget.TableLayout._onMeasure10971 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "onMeasure", "(II)V");
			global::android.widget.TableLayout._checkLayoutParams10972 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z");
			global::android.widget.TableLayout._setOnHierarchyChangeListener10973 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "setOnHierarchyChangeListener", "(Landroid/view/ViewGroup$OnHierarchyChangeListener;)V");
			global::android.widget.TableLayout._generateLayoutParams10974 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/TableLayout$LayoutParams;");
			global::android.widget.TableLayout._generateLayoutParams10975 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/widget/LinearLayout$LayoutParams;");
			global::android.widget.TableLayout._generateDefaultLayoutParams10976 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "generateDefaultLayoutParams", "()Landroid/widget/LinearLayout$LayoutParams;");
			global::android.widget.TableLayout._isShrinkAllColumns10977 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "isShrinkAllColumns", "()Z");
			global::android.widget.TableLayout._setShrinkAllColumns10978 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "setShrinkAllColumns", "(Z)V");
			global::android.widget.TableLayout._isStretchAllColumns10979 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "isStretchAllColumns", "()Z");
			global::android.widget.TableLayout._setStretchAllColumns10980 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "setStretchAllColumns", "(Z)V");
			global::android.widget.TableLayout._setColumnCollapsed10981 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "setColumnCollapsed", "(IZ)V");
			global::android.widget.TableLayout._isColumnCollapsed10982 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "isColumnCollapsed", "(I)Z");
			global::android.widget.TableLayout._setColumnStretchable10983 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "setColumnStretchable", "(IZ)V");
			global::android.widget.TableLayout._isColumnStretchable10984 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "isColumnStretchable", "(I)Z");
			global::android.widget.TableLayout._setColumnShrinkable10985 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "setColumnShrinkable", "(IZ)V");
			global::android.widget.TableLayout._isColumnShrinkable10986 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "isColumnShrinkable", "(I)Z");
			global::android.widget.TableLayout._TableLayout10987 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.TableLayout._TableLayout10988 = @__env.GetMethodID(global::android.widget.TableLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
