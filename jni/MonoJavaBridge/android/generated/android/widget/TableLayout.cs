namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TableLayout : android.widget.LinearLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TableLayout()
		{
			InitJNI();
		}
		protected TableLayout(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public new partial class LayoutParams : android.widget.LinearLayout.LayoutParams
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static LayoutParams()
			{
				InitJNI();
			}
			protected LayoutParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _setBaseAttributes17910;
			protected override void setBaseAttributes(android.content.res.TypedArray arg0, int arg1, int arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableLayout.LayoutParams._setBaseAttributes17910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableLayout.LayoutParams.staticClass, global::android.widget.TableLayout.LayoutParams._setBaseAttributes17910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17911;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableLayout.LayoutParams.staticClass, global::android.widget.TableLayout.LayoutParams._LayoutParams17911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17912;
			public LayoutParams(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableLayout.LayoutParams.staticClass, global::android.widget.TableLayout.LayoutParams._LayoutParams17912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17913;
			public LayoutParams(int arg0, int arg1, float arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableLayout.LayoutParams.staticClass, global::android.widget.TableLayout.LayoutParams._LayoutParams17913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17914;
			public LayoutParams() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableLayout.LayoutParams.staticClass, global::android.widget.TableLayout.LayoutParams._LayoutParams17914);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17915;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableLayout.LayoutParams.staticClass, global::android.widget.TableLayout.LayoutParams._LayoutParams17915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17916;
			public LayoutParams(android.view.ViewGroup.MarginLayoutParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableLayout.LayoutParams.staticClass, global::android.widget.TableLayout.LayoutParams._LayoutParams17916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TableLayout.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TableLayout$LayoutParams"));
				global::android.widget.TableLayout.LayoutParams._setBaseAttributes17910 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.LayoutParams.staticClass, "setBaseAttributes", "(Landroid/content/res/TypedArray;II)V");
				global::android.widget.TableLayout.LayoutParams._LayoutParams17911 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.widget.TableLayout.LayoutParams._LayoutParams17912 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.LayoutParams.staticClass, "<init>", "(II)V");
				global::android.widget.TableLayout.LayoutParams._LayoutParams17913 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.LayoutParams.staticClass, "<init>", "(IIF)V");
				global::android.widget.TableLayout.LayoutParams._LayoutParams17914 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.LayoutParams.staticClass, "<init>", "()V");
				global::android.widget.TableLayout.LayoutParams._LayoutParams17915 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::android.widget.TableLayout.LayoutParams._LayoutParams17916 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _addView17917;
		public override void addView(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableLayout._addView17917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._addView17917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addView17918;
		public override void addView(android.view.View arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableLayout._addView17918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._addView17918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addView17919;
		public override void addView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableLayout._addView17919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._addView17919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addView17920;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableLayout._addView17920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._addView17920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onLayout17921;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableLayout._onLayout17921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._onLayout17921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _requestLayout17922;
		public override void requestLayout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableLayout._requestLayout17922);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._requestLayout17922);
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure17923;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableLayout._onMeasure17923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._onMeasure17923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkLayoutParams17924;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TableLayout._checkLayoutParams17924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._checkLayoutParams17924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableLayout._setOnHierarchyChangeListener17925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._setOnHierarchyChangeListener17925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams17926;
		public virtual global::android.widget.TableLayout.LayoutParams generateLayoutParams(android.util.AttributeSet arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TableLayout._generateLayoutParams17926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TableLayout.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._generateLayoutParams17926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TableLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams17927;
		protected override global::android.widget.LinearLayout.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TableLayout._generateLayoutParams17927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.LinearLayout.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._generateLayoutParams17927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.LinearLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateDefaultLayoutParams17928;
		protected override global::android.widget.LinearLayout.LayoutParams generateDefaultLayoutParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TableLayout._generateDefaultLayoutParams17928)) as android.widget.LinearLayout.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._generateDefaultLayoutParams17928)) as android.widget.LinearLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _isShrinkAllColumns17929;
		public virtual bool isShrinkAllColumns()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TableLayout._isShrinkAllColumns17929);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._isShrinkAllColumns17929);
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableLayout._setShrinkAllColumns17930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._setShrinkAllColumns17930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isStretchAllColumns17931;
		public virtual bool isStretchAllColumns()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TableLayout._isStretchAllColumns17931);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._isStretchAllColumns17931);
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableLayout._setStretchAllColumns17932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._setStretchAllColumns17932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnCollapsed17933;
		public virtual void setColumnCollapsed(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableLayout._setColumnCollapsed17933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._setColumnCollapsed17933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isColumnCollapsed17934;
		public virtual bool isColumnCollapsed(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TableLayout._isColumnCollapsed17934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._isColumnCollapsed17934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnStretchable17935;
		public virtual void setColumnStretchable(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableLayout._setColumnStretchable17935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._setColumnStretchable17935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isColumnStretchable17936;
		public virtual bool isColumnStretchable(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TableLayout._isColumnStretchable17936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._isColumnStretchable17936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColumnShrinkable17937;
		public virtual void setColumnShrinkable(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableLayout._setColumnShrinkable17937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._setColumnShrinkable17937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isColumnShrinkable17938;
		public virtual bool isColumnShrinkable(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TableLayout._isColumnShrinkable17938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TableLayout.staticClass, global::android.widget.TableLayout._isColumnShrinkable17938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _TableLayout17939;
		public TableLayout(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableLayout.staticClass, global::android.widget.TableLayout._TableLayout17939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TableLayout17940;
		public TableLayout(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableLayout.staticClass, global::android.widget.TableLayout._TableLayout17940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.TableLayout.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TableLayout"));
			global::android.widget.TableLayout._addView17917 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "addView", "(Landroid/view/View;)V");
			global::android.widget.TableLayout._addView17918 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "addView", "(Landroid/view/View;I)V");
			global::android.widget.TableLayout._addView17919 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.TableLayout._addView17920 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.TableLayout._onLayout17921 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.TableLayout._requestLayout17922 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "requestLayout", "()V");
			global::android.widget.TableLayout._onMeasure17923 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "onMeasure", "(II)V");
			global::android.widget.TableLayout._checkLayoutParams17924 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z");
			global::android.widget.TableLayout._setOnHierarchyChangeListener17925 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "setOnHierarchyChangeListener", "(Landroid/view/ViewGroup$OnHierarchyChangeListener;)V");
			global::android.widget.TableLayout._generateLayoutParams17926 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/TableLayout$LayoutParams;");
			global::android.widget.TableLayout._generateLayoutParams17927 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/widget/LinearLayout$LayoutParams;");
			global::android.widget.TableLayout._generateDefaultLayoutParams17928 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "generateDefaultLayoutParams", "()Landroid/widget/LinearLayout$LayoutParams;");
			global::android.widget.TableLayout._isShrinkAllColumns17929 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "isShrinkAllColumns", "()Z");
			global::android.widget.TableLayout._setShrinkAllColumns17930 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "setShrinkAllColumns", "(Z)V");
			global::android.widget.TableLayout._isStretchAllColumns17931 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "isStretchAllColumns", "()Z");
			global::android.widget.TableLayout._setStretchAllColumns17932 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "setStretchAllColumns", "(Z)V");
			global::android.widget.TableLayout._setColumnCollapsed17933 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "setColumnCollapsed", "(IZ)V");
			global::android.widget.TableLayout._isColumnCollapsed17934 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "isColumnCollapsed", "(I)Z");
			global::android.widget.TableLayout._setColumnStretchable17935 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "setColumnStretchable", "(IZ)V");
			global::android.widget.TableLayout._isColumnStretchable17936 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "isColumnStretchable", "(I)Z");
			global::android.widget.TableLayout._setColumnShrinkable17937 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "setColumnShrinkable", "(IZ)V");
			global::android.widget.TableLayout._isColumnShrinkable17938 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "isColumnShrinkable", "(I)Z");
			global::android.widget.TableLayout._TableLayout17939 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.TableLayout._TableLayout17940 = @__env.GetMethodIDNoThrow(global::android.widget.TableLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
