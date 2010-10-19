namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AbsoluteLayout : android.view.ViewGroup
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbsoluteLayout()
		{
			InitJNI();
		}
		protected AbsoluteLayout(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public new partial class LayoutParams : android.view.ViewGroup.LayoutParams
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static LayoutParams()
			{
				InitJNI();
			}
			protected LayoutParams(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _debug11370;
			public virtual global::java.lang.String debug(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsoluteLayout.LayoutParams._debug11370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsoluteLayout.LayoutParams.staticClass, global::android.widget.AbsoluteLayout.LayoutParams._debug11370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams11371;
			public LayoutParams(int arg0, int arg1, int arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsoluteLayout.LayoutParams.staticClass, global::android.widget.AbsoluteLayout.LayoutParams._LayoutParams11371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams11372;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsoluteLayout.LayoutParams.staticClass, global::android.widget.AbsoluteLayout.LayoutParams._LayoutParams11372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams11373;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsoluteLayout.LayoutParams.staticClass, global::android.widget.AbsoluteLayout.LayoutParams._LayoutParams11373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _x11374;
			public int x
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _y11375;
			public int y
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AbsoluteLayout.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsoluteLayout$LayoutParams"));
				global::android.widget.AbsoluteLayout.LayoutParams._debug11370 = @__env.GetMethodIDNoThrow(global::android.widget.AbsoluteLayout.LayoutParams.staticClass, "debug", "(Ljava/lang/String;)Ljava/lang/String;");
				global::android.widget.AbsoluteLayout.LayoutParams._LayoutParams11371 = @__env.GetMethodIDNoThrow(global::android.widget.AbsoluteLayout.LayoutParams.staticClass, "<init>", "(IIII)V");
				global::android.widget.AbsoluteLayout.LayoutParams._LayoutParams11372 = @__env.GetMethodIDNoThrow(global::android.widget.AbsoluteLayout.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.widget.AbsoluteLayout.LayoutParams._LayoutParams11373 = @__env.GetMethodIDNoThrow(global::android.widget.AbsoluteLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _onLayout11376;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsoluteLayout._onLayout11376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsoluteLayout.staticClass, global::android.widget.AbsoluteLayout._onLayout11376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure11377;
		protected override void onMeasure(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.AbsoluteLayout._onMeasure11377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.AbsoluteLayout.staticClass, global::android.widget.AbsoluteLayout._onMeasure11377, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkLayoutParams11378;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.widget.AbsoluteLayout._checkLayoutParams11378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.widget.AbsoluteLayout.staticClass, global::android.widget.AbsoluteLayout._checkLayoutParams11378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams11379;
		protected override global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsoluteLayout._generateLayoutParams11379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsoluteLayout.staticClass, global::android.widget.AbsoluteLayout._generateLayoutParams11379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams11380;
		public override global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.util.AttributeSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsoluteLayout._generateLayoutParams11380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsoluteLayout.staticClass, global::android.widget.AbsoluteLayout._generateLayoutParams11380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateDefaultLayoutParams11381;
		protected override global::android.view.ViewGroup.LayoutParams generateDefaultLayoutParams() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.AbsoluteLayout._generateDefaultLayoutParams11381)) as android.view.ViewGroup.LayoutParams;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.AbsoluteLayout.staticClass, global::android.widget.AbsoluteLayout._generateDefaultLayoutParams11381)) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _AbsoluteLayout11382;
		public AbsoluteLayout(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsoluteLayout.staticClass, global::android.widget.AbsoluteLayout._AbsoluteLayout11382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsoluteLayout11383;
		public AbsoluteLayout(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsoluteLayout.staticClass, global::android.widget.AbsoluteLayout._AbsoluteLayout11383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsoluteLayout11384;
		public AbsoluteLayout(android.content.Context arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsoluteLayout.staticClass, global::android.widget.AbsoluteLayout._AbsoluteLayout11384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AbsoluteLayout.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsoluteLayout"));
			global::android.widget.AbsoluteLayout._onLayout11376 = @__env.GetMethodIDNoThrow(global::android.widget.AbsoluteLayout.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.AbsoluteLayout._onMeasure11377 = @__env.GetMethodIDNoThrow(global::android.widget.AbsoluteLayout.staticClass, "onMeasure", "(II)V");
			global::android.widget.AbsoluteLayout._checkLayoutParams11378 = @__env.GetMethodIDNoThrow(global::android.widget.AbsoluteLayout.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z");
			global::android.widget.AbsoluteLayout._generateLayoutParams11379 = @__env.GetMethodIDNoThrow(global::android.widget.AbsoluteLayout.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;");
			global::android.widget.AbsoluteLayout._generateLayoutParams11380 = @__env.GetMethodIDNoThrow(global::android.widget.AbsoluteLayout.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/view/ViewGroup$LayoutParams;");
			global::android.widget.AbsoluteLayout._generateDefaultLayoutParams11381 = @__env.GetMethodIDNoThrow(global::android.widget.AbsoluteLayout.staticClass, "generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;");
			global::android.widget.AbsoluteLayout._AbsoluteLayout11382 = @__env.GetMethodIDNoThrow(global::android.widget.AbsoluteLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.AbsoluteLayout._AbsoluteLayout11383 = @__env.GetMethodIDNoThrow(global::android.widget.AbsoluteLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.AbsoluteLayout._AbsoluteLayout11384 = @__env.GetMethodIDNoThrow(global::android.widget.AbsoluteLayout.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}
}
