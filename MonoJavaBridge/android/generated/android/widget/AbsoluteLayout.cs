namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AbsoluteLayout : android.view.ViewGroup
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbsoluteLayout(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public new partial class LayoutParams : android.view.ViewGroup.LayoutParams
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected LayoutParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual global::java.lang.String debug(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.widget.AbsoluteLayout.LayoutParams.staticClass, "debug", "(Ljava/lang/String;)Ljava/lang/String;", ref global::android.widget.AbsoluteLayout.LayoutParams._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public LayoutParams(int arg0, int arg1, int arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.AbsoluteLayout.LayoutParams._m1.native == global::System.IntPtr.Zero)
					global::android.widget.AbsoluteLayout.LayoutParams._m1 = @__env.GetMethodIDNoThrow(global::android.widget.AbsoluteLayout.LayoutParams.staticClass, "<init>", "(IIII)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsoluteLayout.LayoutParams.staticClass, global::android.widget.AbsoluteLayout.LayoutParams._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.AbsoluteLayout.LayoutParams._m2.native == global::System.IntPtr.Zero)
					global::android.widget.AbsoluteLayout.LayoutParams._m2 = @__env.GetMethodIDNoThrow(global::android.widget.AbsoluteLayout.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsoluteLayout.LayoutParams.staticClass, global::android.widget.AbsoluteLayout.LayoutParams._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.AbsoluteLayout.LayoutParams._m3.native == global::System.IntPtr.Zero)
					global::android.widget.AbsoluteLayout.LayoutParams._m3 = @__env.GetMethodIDNoThrow(global::android.widget.AbsoluteLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsoluteLayout.LayoutParams.staticClass, global::android.widget.AbsoluteLayout.LayoutParams._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _x6031;
			public int x
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _x6031);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _y6032;
			public int y
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _y6032);
				}
				set
				{
				}
			}
			static LayoutParams()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AbsoluteLayout.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsoluteLayout$LayoutParams"));
				global::android.widget.AbsoluteLayout.LayoutParams._x6031 = @__env.GetFieldIDNoThrow(global::android.widget.AbsoluteLayout.LayoutParams.staticClass, "x", "I");
				global::android.widget.AbsoluteLayout.LayoutParams._y6032 = @__env.GetFieldIDNoThrow(global::android.widget.AbsoluteLayout.LayoutParams.staticClass, "y", "I");
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsoluteLayout.staticClass, "onLayout", "(ZIIII)V", ref global::android.widget.AbsoluteLayout._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsoluteLayout.staticClass, "onMeasure", "(II)V", ref global::android.widget.AbsoluteLayout._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsoluteLayout.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z", ref global::android.widget.AbsoluteLayout._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.AbsoluteLayout.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;", ref global::android.widget.AbsoluteLayout._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.ViewGroup.LayoutParams;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.util.AttributeSet arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.AbsoluteLayout.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/view/ViewGroup$LayoutParams;", ref global::android.widget.AbsoluteLayout._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.ViewGroup.LayoutParams;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override global::android.view.ViewGroup.LayoutParams generateDefaultLayoutParams()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.AbsoluteLayout.staticClass, "generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;", ref global::android.widget.AbsoluteLayout._m5) as android.view.ViewGroup.LayoutParams;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public AbsoluteLayout(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsoluteLayout._m6.native == global::System.IntPtr.Zero)
				global::android.widget.AbsoluteLayout._m6 = @__env.GetMethodIDNoThrow(global::android.widget.AbsoluteLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsoluteLayout.staticClass, global::android.widget.AbsoluteLayout._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public AbsoluteLayout(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsoluteLayout._m7.native == global::System.IntPtr.Zero)
				global::android.widget.AbsoluteLayout._m7 = @__env.GetMethodIDNoThrow(global::android.widget.AbsoluteLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsoluteLayout.staticClass, global::android.widget.AbsoluteLayout._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public AbsoluteLayout(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.AbsoluteLayout._m8.native == global::System.IntPtr.Zero)
				global::android.widget.AbsoluteLayout._m8 = @__env.GetMethodIDNoThrow(global::android.widget.AbsoluteLayout.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsoluteLayout.staticClass, global::android.widget.AbsoluteLayout._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AbsoluteLayout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AbsoluteLayout.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsoluteLayout"));
		}
		internal static void InitJNI()
		{
		}
	}
}
