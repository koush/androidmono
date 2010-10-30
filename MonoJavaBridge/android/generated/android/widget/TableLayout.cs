namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TableLayout : android.widget.LinearLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TableLayout(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public new partial class LayoutParams : android.widget.LinearLayout.LayoutParams
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected LayoutParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _setBaseAttributes17910;
			protected override void setBaseAttributes(android.content.res.TypedArray arg0, int arg1, int arg2)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TableLayout.LayoutParams.staticClass, "setBaseAttributes", "(Landroid/content/res/TypedArray;II)V", ref global::android.widget.TableLayout.LayoutParams._setBaseAttributes17910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17911;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.TableLayout.LayoutParams._LayoutParams17911.native == global::System.IntPtr.Zero)
					global::android.widget.TableLayout.LayoutParams._LayoutParams17911 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableLayout.LayoutParams.staticClass, global::android.widget.TableLayout.LayoutParams._LayoutParams17911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17912;
			public LayoutParams(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.TableLayout.LayoutParams._LayoutParams17912.native == global::System.IntPtr.Zero)
					global::android.widget.TableLayout.LayoutParams._LayoutParams17912 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.LayoutParams.staticClass, "<init>", "(II)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableLayout.LayoutParams.staticClass, global::android.widget.TableLayout.LayoutParams._LayoutParams17912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17913;
			public LayoutParams(int arg0, int arg1, float arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.TableLayout.LayoutParams._LayoutParams17913.native == global::System.IntPtr.Zero)
					global::android.widget.TableLayout.LayoutParams._LayoutParams17913 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.LayoutParams.staticClass, "<init>", "(IIF)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableLayout.LayoutParams.staticClass, global::android.widget.TableLayout.LayoutParams._LayoutParams17913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17914;
			public LayoutParams() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.TableLayout.LayoutParams._LayoutParams17914.native == global::System.IntPtr.Zero)
					global::android.widget.TableLayout.LayoutParams._LayoutParams17914 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.LayoutParams.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableLayout.LayoutParams.staticClass, global::android.widget.TableLayout.LayoutParams._LayoutParams17914);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17915;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.TableLayout.LayoutParams._LayoutParams17915.native == global::System.IntPtr.Zero)
					global::android.widget.TableLayout.LayoutParams._LayoutParams17915 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableLayout.LayoutParams.staticClass, global::android.widget.TableLayout.LayoutParams._LayoutParams17915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17916;
			public LayoutParams(android.view.ViewGroup.MarginLayoutParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.TableLayout.LayoutParams._LayoutParams17916.native == global::System.IntPtr.Zero)
					global::android.widget.TableLayout.LayoutParams._LayoutParams17916 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableLayout.LayoutParams.staticClass, global::android.widget.TableLayout.LayoutParams._LayoutParams17916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static LayoutParams()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TableLayout.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TableLayout$LayoutParams"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _addView17917;
		public override void addView(android.view.View arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TableLayout.staticClass, "addView", "(Landroid/view/View;)V", ref global::android.widget.TableLayout._addView17917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView17918;
		public override void addView(android.view.View arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TableLayout.staticClass, "addView", "(Landroid/view/View;I)V", ref global::android.widget.TableLayout._addView17918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addView17919;
		public override void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TableLayout.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", ref global::android.widget.TableLayout._addView17919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addView17920;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TableLayout.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V", ref global::android.widget.TableLayout._addView17920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onLayout17921;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TableLayout.staticClass, "onLayout", "(ZIIII)V", ref global::android.widget.TableLayout._onLayout17921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _requestLayout17922;
		public override void requestLayout()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TableLayout.staticClass, "requestLayout", "()V", ref global::android.widget.TableLayout._requestLayout17922);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure17923;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TableLayout.staticClass, "onMeasure", "(II)V", ref global::android.widget.TableLayout._onMeasure17923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkLayoutParams17924;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TableLayout.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z", ref global::android.widget.TableLayout._checkLayoutParams17924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.ViewGroup.OnHierarchyChangeListener OnHierarchyChangeListener
		{
			set
			{
				setOnHierarchyChangeListener(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setOnHierarchyChangeListener17925;
		public override void setOnHierarchyChangeListener(android.view.ViewGroup.OnHierarchyChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TableLayout.staticClass, "setOnHierarchyChangeListener", "(Landroid/view/ViewGroup$OnHierarchyChangeListener;)V", ref global::android.widget.TableLayout._setOnHierarchyChangeListener17925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams17926;
		public virtual global::android.widget.TableLayout.LayoutParams generateLayoutParams(android.util.AttributeSet arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TableLayout.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/TableLayout$LayoutParams;", ref global::android.widget.TableLayout._generateLayoutParams17926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.widget.TableLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams17927;
		protected override global::android.widget.LinearLayout.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TableLayout.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/widget/LinearLayout$LayoutParams;", ref global::android.widget.TableLayout._generateLayoutParams17927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.widget.LinearLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateDefaultLayoutParams17928;
		protected override global::android.widget.LinearLayout.LayoutParams generateDefaultLayoutParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TableLayout.staticClass, "generateDefaultLayoutParams", "()Landroid/widget/LinearLayout$LayoutParams;", ref global::android.widget.TableLayout._generateDefaultLayoutParams17928) as android.widget.LinearLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _isShrinkAllColumns17929;
		public virtual bool isShrinkAllColumns()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TableLayout.staticClass, "isShrinkAllColumns", "()Z", ref global::android.widget.TableLayout._isShrinkAllColumns17929);
		}
		public new bool ShrinkAllColumns
		{
			set
			{
				setShrinkAllColumns(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setShrinkAllColumns17930;
		public virtual void setShrinkAllColumns(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TableLayout.staticClass, "setShrinkAllColumns", "(Z)V", ref global::android.widget.TableLayout._setShrinkAllColumns17930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStretchAllColumns17931;
		public virtual bool isStretchAllColumns()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TableLayout.staticClass, "isStretchAllColumns", "()Z", ref global::android.widget.TableLayout._isStretchAllColumns17931);
		}
		public new bool StretchAllColumns
		{
			set
			{
				setStretchAllColumns(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setStretchAllColumns17932;
		public virtual void setStretchAllColumns(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TableLayout.staticClass, "setStretchAllColumns", "(Z)V", ref global::android.widget.TableLayout._setStretchAllColumns17932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnCollapsed17933;
		public virtual void setColumnCollapsed(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TableLayout.staticClass, "setColumnCollapsed", "(IZ)V", ref global::android.widget.TableLayout._setColumnCollapsed17933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isColumnCollapsed17934;
		public virtual bool isColumnCollapsed(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TableLayout.staticClass, "isColumnCollapsed", "(I)Z", ref global::android.widget.TableLayout._isColumnCollapsed17934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnStretchable17935;
		public virtual void setColumnStretchable(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TableLayout.staticClass, "setColumnStretchable", "(IZ)V", ref global::android.widget.TableLayout._setColumnStretchable17935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isColumnStretchable17936;
		public virtual bool isColumnStretchable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TableLayout.staticClass, "isColumnStretchable", "(I)Z", ref global::android.widget.TableLayout._isColumnStretchable17936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnShrinkable17937;
		public virtual void setColumnShrinkable(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TableLayout.staticClass, "setColumnShrinkable", "(IZ)V", ref global::android.widget.TableLayout._setColumnShrinkable17937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isColumnShrinkable17938;
		public virtual bool isColumnShrinkable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TableLayout.staticClass, "isColumnShrinkable", "(I)Z", ref global::android.widget.TableLayout._isColumnShrinkable17938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _TableLayout17939;
		public TableLayout(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.TableLayout._TableLayout17939.native == global::System.IntPtr.Zero)
				global::android.widget.TableLayout._TableLayout17939 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableLayout.staticClass, global::android.widget.TableLayout._TableLayout17939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TableLayout17940;
		public TableLayout(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.TableLayout._TableLayout17940.native == global::System.IntPtr.Zero)
				global::android.widget.TableLayout._TableLayout17940 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableLayout.staticClass, global::android.widget.TableLayout._TableLayout17940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static TableLayout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.TableLayout.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TableLayout"));
		}
		internal static void InitJNI()
		{
		}
	}
}
