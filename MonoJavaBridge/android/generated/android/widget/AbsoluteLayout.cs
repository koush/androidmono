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
			internal static global::MonoJavaBridge.MethodId _debug16601;
			public virtual global::java.lang.String debug(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.AbsoluteLayout.LayoutParams.staticClass, global::android.widget.AbsoluteLayout.LayoutParams._debug16601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams16602;
			public LayoutParams(int arg0, int arg1, int arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsoluteLayout.LayoutParams.staticClass, global::android.widget.AbsoluteLayout.LayoutParams._LayoutParams16602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams16603;
			public LayoutParams(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsoluteLayout.LayoutParams.staticClass, global::android.widget.AbsoluteLayout.LayoutParams._LayoutParams16603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _LayoutParams16604;
			public LayoutParams(android.view.ViewGroup.LayoutParams arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsoluteLayout.LayoutParams.staticClass, global::android.widget.AbsoluteLayout.LayoutParams._LayoutParams16604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _x16605;
			public int x
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _x16605);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _y16606;
			public int y
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _y16606);
				}
				set
				{
				}
			}
			static LayoutParams()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.AbsoluteLayout.LayoutParams.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsoluteLayout$LayoutParams"));
				global::android.widget.AbsoluteLayout.LayoutParams._debug16601 = @__env.GetMethodIDNoThrow(global::android.widget.AbsoluteLayout.LayoutParams.staticClass, "debug", "(Ljava/lang/String;)Ljava/lang/String;");
				global::android.widget.AbsoluteLayout.LayoutParams._LayoutParams16602 = @__env.GetMethodIDNoThrow(global::android.widget.AbsoluteLayout.LayoutParams.staticClass, "<init>", "(IIII)V");
				global::android.widget.AbsoluteLayout.LayoutParams._LayoutParams16603 = @__env.GetMethodIDNoThrow(global::android.widget.AbsoluteLayout.LayoutParams.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				global::android.widget.AbsoluteLayout.LayoutParams._LayoutParams16604 = @__env.GetMethodIDNoThrow(global::android.widget.AbsoluteLayout.LayoutParams.staticClass, "<init>", "(Landroid/view/ViewGroup$LayoutParams;)V");
				global::android.widget.AbsoluteLayout.LayoutParams._x16605 = @__env.GetFieldIDNoThrow(global::android.widget.AbsoluteLayout.LayoutParams.staticClass, "x", "I");
				global::android.widget.AbsoluteLayout.LayoutParams._y16606 = @__env.GetFieldIDNoThrow(global::android.widget.AbsoluteLayout.LayoutParams.staticClass, "y", "I");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _onLayout16607;
		protected override void onLayout(bool arg0, int arg1, int arg2, int arg3, int arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsoluteLayout.staticClass, global::android.widget.AbsoluteLayout._onLayout16607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _onMeasure16608;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.AbsoluteLayout.staticClass, global::android.widget.AbsoluteLayout._onMeasure16608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkLayoutParams16609;
		protected override bool checkLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.widget.AbsoluteLayout.staticClass, global::android.widget.AbsoluteLayout._checkLayoutParams16609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams16610;
		protected override global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.view.ViewGroup.LayoutParams arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.AbsoluteLayout.staticClass, global::android.widget.AbsoluteLayout._generateLayoutParams16610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateLayoutParams16611;
		public override global::android.view.ViewGroup.LayoutParams generateLayoutParams(android.util.AttributeSet arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.AbsoluteLayout.staticClass, global::android.widget.AbsoluteLayout._generateLayoutParams16611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _generateDefaultLayoutParams16612;
		protected override global::android.view.ViewGroup.LayoutParams generateDefaultLayoutParams()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.AbsoluteLayout.staticClass, global::android.widget.AbsoluteLayout._generateDefaultLayoutParams16612)) as android.view.ViewGroup.LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _AbsoluteLayout16613;
		public AbsoluteLayout(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsoluteLayout.staticClass, global::android.widget.AbsoluteLayout._AbsoluteLayout16613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsoluteLayout16614;
		public AbsoluteLayout(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsoluteLayout.staticClass, global::android.widget.AbsoluteLayout._AbsoluteLayout16614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsoluteLayout16615;
		public AbsoluteLayout(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.AbsoluteLayout.staticClass, global::android.widget.AbsoluteLayout._AbsoluteLayout16615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AbsoluteLayout()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.AbsoluteLayout.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/AbsoluteLayout"));
			global::android.widget.AbsoluteLayout._onLayout16607 = @__env.GetMethodIDNoThrow(global::android.widget.AbsoluteLayout.staticClass, "onLayout", "(ZIIII)V");
			global::android.widget.AbsoluteLayout._onMeasure16608 = @__env.GetMethodIDNoThrow(global::android.widget.AbsoluteLayout.staticClass, "onMeasure", "(II)V");
			global::android.widget.AbsoluteLayout._checkLayoutParams16609 = @__env.GetMethodIDNoThrow(global::android.widget.AbsoluteLayout.staticClass, "checkLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Z");
			global::android.widget.AbsoluteLayout._generateLayoutParams16610 = @__env.GetMethodIDNoThrow(global::android.widget.AbsoluteLayout.staticClass, "generateLayoutParams", "(Landroid/view/ViewGroup$LayoutParams;)Landroid/view/ViewGroup$LayoutParams;");
			global::android.widget.AbsoluteLayout._generateLayoutParams16611 = @__env.GetMethodIDNoThrow(global::android.widget.AbsoluteLayout.staticClass, "generateLayoutParams", "(Landroid/util/AttributeSet;)Landroid/view/ViewGroup$LayoutParams;");
			global::android.widget.AbsoluteLayout._generateDefaultLayoutParams16612 = @__env.GetMethodIDNoThrow(global::android.widget.AbsoluteLayout.staticClass, "generateDefaultLayoutParams", "()Landroid/view/ViewGroup$LayoutParams;");
			global::android.widget.AbsoluteLayout._AbsoluteLayout16613 = @__env.GetMethodIDNoThrow(global::android.widget.AbsoluteLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.AbsoluteLayout._AbsoluteLayout16614 = @__env.GetMethodIDNoThrow(global::android.widget.AbsoluteLayout.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::android.widget.AbsoluteLayout._AbsoluteLayout16615 = @__env.GetMethodIDNoThrow(global::android.widget.AbsoluteLayout.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
