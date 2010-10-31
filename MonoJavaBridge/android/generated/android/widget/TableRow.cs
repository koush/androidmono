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
			private static global::MonoJavaBridge.MethodId _m0;
			protected override void setBaseAttributes(android.content.res.TypedArray arg0, int arg1, int arg2)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TableRow.LayoutParams.staticClass, "setBaseAttributes", "(Landroid/content/res/TypedArray;II)V", ref global::android.widget.TableRow.LayoutParams._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.TableRow.LayoutParams._m1.native == global::System.IntPtr.Zero)
					global::android.widget.TableRow.LayoutParams._m1 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableRow.LayoutParams.staticClass, global::android.widget.TableRow.LayoutParams._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public LayoutParams(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.TableRow.LayoutParams._m2.native == global::System.IntPtr.Zero)
					global::android.widget.TableRow.LayoutParams._m2 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.LayoutParams.staticClass, "<init>", "(II)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableRow.LayoutParams.staticClass, global::android.widget.TableRow.LayoutParams._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public LayoutParams(int arg0, int arg1, float arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.TableRow.LayoutParams._m3.native == global::System.IntPtr.Zero)
					global::android.widget.TableRow.LayoutParams._m3 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.LayoutParams.staticClass, "<init>", "(IIF)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableRow.LayoutParams.staticClass, global::android.widget.TableRow.LayoutParams._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public LayoutParams() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.TableRow.LayoutParams._m4.native == global::System.IntPtr.Zero)
					global::android.widget.TableRow.LayoutParams._m4 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.LayoutParams.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableRow.LayoutParams.staticClass, global::android.widget.TableRow.LayoutParams._m4);
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public LayoutParams(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.TableRow.LayoutParams._m5.native == global::System.IntPtr.Zero)
					global::android.widget.TableRow.LayoutParams._m5 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.LayoutParams.staticClass, "<init>", "(I)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableRow.LayoutParams.staticClass, global::android.widget.TableRow.LayoutParams._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.TableRow.LayoutParams._m6.native == global::System.IntPtr.Zero)
					global::android.widget.TableRow.LayoutParams._m6 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableRow.LayoutParams.staticClass, global::android.widget.TableRow.LayoutParams._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m7;
			public LayoutParams(android.view.ViewGroup.MarginLayoutParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.TableRow.LayoutParams._m7.native == global::System.IntPtr.Zero)
					global::android.widget.TableRow.LayoutParams._m7 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$MarginLayoutParams;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableRow.LayoutParams.staticClass, global::android.widget.TableRow.LayoutParams._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _column6105;
			public int column
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _column6105);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _span6106;
			public int span
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _span6106);
				}
				set
				{
				}
			}
			static LayoutParams()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.TableRow.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TableRow$LayoutParams"));
				global::android.widget.TableRow.LayoutParams._column6105 = @__env.GetFieldIDNoThrow(global::android.widget.TableRow.LayoutParams.staticClass, "column", "I");
				global::android.widget.TableRow.LayoutParams._span6106 = @__env.GetFieldIDNoThrow(global::android.widget.TableRow.LayoutParams.staticClass, "span", "I");
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TableRow.staticClass, "onLayout", "(ZIIII)V", ref global::android.widget.TableRow._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TableRow.staticClass, "onMeasure", "(II)V", ref global::android.widget.TableRow._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.TableRow.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z", ref global::android.widget.TableRow._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.ViewGroup.OnHierarchyChangeListener OnHierarchyChangeListener
		{
			set
			{
				setOnHierarchyChangeListener(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void setOnHierarchyChangeListener(android.view.ViewGroup.OnHierarchyChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.TableRow.staticClass, "setOnHierarchyChangeListener", "(Landroid/view/ViewGroup$OnHierarchyChangeListener;)V", ref global::android.widget.TableRow._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::android.widget.TableRow.LayoutParams generateLayoutParams(android.util.AttributeSet arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TableRow.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/widget/TableRow$LayoutParams;", ref global::android.widget.TableRow._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.widget.TableRow.LayoutParams;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override global::android.widget.LinearLayout.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TableRow.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/widget/LinearLayout$LayoutParams;", ref global::android.widget.TableRow._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.widget.LinearLayout.LayoutParams;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected override global::android.widget.LinearLayout.LayoutParams generateDefaultLayoutParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TableRow.staticClass, "generateDefaultLayoutParams", "()Landroid/widget/LinearLayout$LayoutParams;", ref global::android.widget.TableRow._m6) as android.widget.LinearLayout.LayoutParams;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::android.view.View getVirtualChildAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.TableRow.staticClass, "getVirtualChildAt", "(I)Landroid/view/View;", ref global::android.widget.TableRow._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.View;
		}
		public new int VirtualChildCount
		{
			get
			{
				return getVirtualChildCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual int getVirtualChildCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.widget.TableRow.staticClass, "getVirtualChildCount", "()I", ref global::android.widget.TableRow._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public TableRow(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.TableRow._m9.native == global::System.IntPtr.Zero)
				global::android.widget.TableRow._m9 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableRow.staticClass, global::android.widget.TableRow._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public TableRow(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.TableRow._m10.native == global::System.IntPtr.Zero)
				global::android.widget.TableRow._m10 = @__env.GetMethodIDNoThrow(global::android.widget.TableRow.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.TableRow.staticClass, global::android.widget.TableRow._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static TableRow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.TableRow.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/TableRow"));
		}
	}
}
