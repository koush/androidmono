namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TableRow : android.widget.LinearLayout
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TableRow(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public new partial class LayoutParams : android.widget.LinearLayout.LayoutParams
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected LayoutParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _setBaseAttributes17941;
			protected override void setBaseAttributes(android.content.res.TypedArray arg0, int arg1, int arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableRow.LayoutParams._setBaseAttributes17941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableRow.LayoutParams.staticClass, global::android.widget.TableRow.LayoutParams._setBaseAttributes17941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17942;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableRow.LayoutParams.staticClass, global::android.widget.TableRow.LayoutParams._LayoutParams17942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17943;
			public LayoutParams(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableRow.LayoutParams.staticClass, global::android.widget.TableRow.LayoutParams._LayoutParams17943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17944;
			public LayoutParams(int arg0, int arg1, float arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableRow.LayoutParams.staticClass, global::android.widget.TableRow.LayoutParams._LayoutParams17944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17945;
			public LayoutParams() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableRow.LayoutParams.staticClass, global::android.widget.TableRow.LayoutParams._LayoutParams17945);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17946;
			public LayoutParams(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableRow.LayoutParams.staticClass, global::android.widget.TableRow.LayoutParams._LayoutParams17946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17947;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableRow.LayoutParams.staticClass, global::android.widget.TableRow.LayoutParams._LayoutParams17947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams17948;
			public LayoutParams(android.view.ViewGroup.MarginLayoutParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableRow.LayoutParams.staticClass, global::android.widget.TableRow.LayoutParams._LayoutParams17948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _column17949;
			public int column
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _column17949);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _span17950;
			public int span
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _span17950);
				}
				set
				{
				}
			}
			static LayoutParams()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TableRow.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TableRow$LayoutParams"));
				global::android.widget.TableRow.LayoutParams._setBaseAttributes17941 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.LayoutParams.staticClass, "setBaseAttributes", "(Landroid/content/res/TypedArray;II)V");
				global::android.widget.TableRow.LayoutParams._LayoutParams17942 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.widget.TableRow.LayoutParams._LayoutParams17943 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.LayoutParams.staticClass, "<init>", "(II)V");
				global::android.widget.TableRow.LayoutParams._LayoutParams17944 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.LayoutParams.staticClass, "<init>", "(IIF)V");
				global::android.widget.TableRow.LayoutParams._LayoutParams17945 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.LayoutParams.staticClass, "<init>", "()V");
				global::android.widget.TableRow.LayoutParams._LayoutParams17946 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.LayoutParams.staticClass, "<init>", "(I)V");
				global::android.widget.TableRow.LayoutParams._LayoutParams17947 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::android.widget.TableRow.LayoutParams._LayoutParams17948 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V");
				global::android.widget.TableRow.LayoutParams._column17949 = @__env.GetFieldIDNoThrow(global::android.widget.TableRow.LayoutParams.staticClass, "column", "I");
				global::android.widget.TableRow.LayoutParams._span17950 = @__env.GetFieldIDNoThrow(global::android.widget.TableRow.LayoutParams.staticClass, "span", "I");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _onLayout17951;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableRow._onLayout17951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableRow.staticClass, global::android.widget.TableRow._onLayout17951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure17952;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableRow._onMeasure17952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableRow.staticClass, global::android.widget.TableRow._onMeasure17952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkLayoutParams17953;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.TableRow._checkLayoutParams17953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.TableRow.staticClass, global::android.widget.TableRow._checkLayoutParams17953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.ViewGroup.OnHierarchyChangeListener OnHierarchyChangeListener
		{
			set
			{
				setOnHierarchyChangeListener(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setOnHierarchyChangeListener17954;
		public override void setOnHierarchyChangeListener(android.view.ViewGroup.OnHierarchyChangeListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.TableRow._setOnHierarchyChangeListener17954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.TableRow.staticClass, global::android.widget.TableRow._setOnHierarchyChangeListener17954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams17955;
		public virtual global::android.widget.TableRow.LayoutParams generateLayoutParams(android.util.AttributeSet arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TableRow._generateLayoutParams17955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TableRow.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TableRow.staticClass, global::android.widget.TableRow._generateLayoutParams17955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.TableRow.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams17956;
		protected override global::android.widget.LinearLayout.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TableRow._generateLayoutParams17956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.LinearLayout.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TableRow.staticClass, global::android.widget.TableRow._generateLayoutParams17956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.widget.LinearLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateDefaultLayoutParams17957;
		protected override global::android.widget.LinearLayout.LayoutParams generateDefaultLayoutParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TableRow._generateDefaultLayoutParams17957)) as android.widget.LinearLayout.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TableRow.staticClass, global::android.widget.TableRow._generateDefaultLayoutParams17957)) as android.widget.LinearLayout.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _getVirtualChildAt17958;
		public virtual global::android.view.View getVirtualChildAt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.TableRow._getVirtualChildAt17958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.TableRow.staticClass, global::android.widget.TableRow._getVirtualChildAt17958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
		}
		public new int VirtualChildCount
		{
			get
			{
				return getVirtualChildCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVirtualChildCount17959;
		public virtual int getVirtualChildCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.widget.TableRow._getVirtualChildCount17959);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.widget.TableRow.staticClass, global::android.widget.TableRow._getVirtualChildCount17959);
		}
		internal static global::MonoJavaBridge.MethodId _TableRow17960;
		public TableRow(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableRow.staticClass, global::android.widget.TableRow._TableRow17960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _TableRow17961;
		public TableRow(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableRow.staticClass, global::android.widget.TableRow._TableRow17961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static TableRow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.TableRow.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TableRow"));
			global::android.widget.TableRow._onLayout17951 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.TableRow._onMeasure17952 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.staticClass, "onMeasure", "(II)V");
			global::android.widget.TableRow._checkLayoutParams17953 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z");
			global::android.widget.TableRow._setOnHierarchyChangeListener17954 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.staticClass, "setOnHierarchyChangeListener", "(Landroid/view/ViewGroup$OnHierarchyChangeListener;)V");
			global::android.widget.TableRow._generateLayoutParams17955 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/TableRow$LayoutParams;");
			global::android.widget.TableRow._generateLayoutParams17956 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/widget/LinearLayout$LayoutParams;");
			global::android.widget.TableRow._generateDefaultLayoutParams17957 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.staticClass, "generateDefaultLayoutParams", "()Landroid/widget/LinearLayout$LayoutParams;");
			global::android.widget.TableRow._getVirtualChildAt17958 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.staticClass, "getVirtualChildAt", "(I)Landroid/view/View;");
			global::android.widget.TableRow._getVirtualChildCount17959 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.staticClass, "getVirtualChildCount", "()I");
			global::android.widget.TableRow._TableRow17960 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.TableRow._TableRow17961 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
