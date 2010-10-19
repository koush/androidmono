namespace android.text.method
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TextKeyListener : android.text.method.BaseKeyListener, SpanWatcher
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TextKeyListener()
		{
			InitJNI();
		}
		protected TextKeyListener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Capitalize : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Capitalize()
			{
				InitJNI();
			}
			internal Capitalize(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values8716;
			public static global::android.text.method.TextKeyListener.Capitalize[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.method.TextKeyListener.Capitalize>(@__env.CallStaticObjectMethod(android.text.method.TextKeyListener.Capitalize.staticClass, global::android.text.method.TextKeyListener.Capitalize._values8716)) as android.text.method.TextKeyListener.Capitalize[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf8717;
			public static global::android.text.method.TextKeyListener.Capitalize valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.TextKeyListener.Capitalize.staticClass, global::android.text.method.TextKeyListener.Capitalize._valueOf8717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.method.TextKeyListener.Capitalize;
			}
			internal static global::MonoJavaBridge.FieldId _CHARACTERS8718;
			public static global::android.text.method.TextKeyListener.Capitalize CHARACTERS
			{
				get
				{
					return default(global::android.text.method.TextKeyListener.Capitalize);
				}
			}
			internal static global::MonoJavaBridge.FieldId _NONE8719;
			public static global::android.text.method.TextKeyListener.Capitalize NONE
			{
				get
				{
					return default(global::android.text.method.TextKeyListener.Capitalize);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SENTENCES8720;
			public static global::android.text.method.TextKeyListener.Capitalize SENTENCES
			{
				get
				{
					return default(global::android.text.method.TextKeyListener.Capitalize);
				}
			}
			internal static global::MonoJavaBridge.FieldId _WORDS8721;
			public static global::android.text.method.TextKeyListener.Capitalize WORDS
			{
				get
				{
					return default(global::android.text.method.TextKeyListener.Capitalize);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.method.TextKeyListener.Capitalize.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/TextKeyListener$Capitalize"));
				global::android.text.method.TextKeyListener.Capitalize._values8716 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.TextKeyListener.Capitalize.staticClass, "values", "()[Landroid/text/method/TextKeyListener/Capitalize;");
				global::android.text.method.TextKeyListener.Capitalize._valueOf8717 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.TextKeyListener.Capitalize.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/text/method/TextKeyListener$Capitalize;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _clear8722;
		public static void clear(android.text.Editable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._clear8722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInstance8723;
		public static global::android.text.method.TextKeyListener getInstance(bool arg0, android.text.method.TextKeyListener.Capitalize arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._getInstance8723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.method.TextKeyListener;
		}
		public static global::android.text.method.TextKeyListener Instance
		{
			get
			{
				return getInstance();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInstance8724;
		public static global::android.text.method.TextKeyListener getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._getInstance8724)) as android.text.method.TextKeyListener;
		}
		internal static global::MonoJavaBridge.MethodId _release8725;
		public virtual void release() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.method.TextKeyListener._release8725);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._release8725);
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown8726;
		public override bool onKeyDown(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.TextKeyListener._onKeyDown8726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._onKeyDown8726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp8727;
		public override bool onKeyUp(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.TextKeyListener._onKeyUp8727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._onKeyUp8727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new int InputType
		{
			get
			{
				return getInputType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputType8728;
		public override int getInputType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.method.TextKeyListener._getInputType8728);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._getInputType8728);
		}
		internal static global::MonoJavaBridge.MethodId _onKeyOther8729;
		public override bool onKeyOther(android.view.View arg0, android.text.Editable arg1, android.view.KeyEvent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.TextKeyListener._onKeyOther8729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._onKeyOther8729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onSpanAdded8730;
		public virtual void onSpanAdded(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.method.TextKeyListener._onSpanAdded8730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._onSpanAdded8730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onSpanRemoved8731;
		public virtual void onSpanRemoved(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.method.TextKeyListener._onSpanRemoved8731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._onSpanRemoved8731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onSpanChanged8732;
		public virtual void onSpanChanged(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.method.TextKeyListener._onSpanChanged8732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._onSpanChanged8732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _shouldCap8733;
		public static bool shouldCap(android.text.method.TextKeyListener.Capitalize arg0, java.lang.CharSequence arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._shouldCap8733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _TextKeyListener8734;
		public TextKeyListener(android.text.method.TextKeyListener.Capitalize arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._TextKeyListener8734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.TextKeyListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/TextKeyListener"));
			global::android.text.method.TextKeyListener._clear8722 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.TextKeyListener.staticClass, "clear", "(Landroid/text/Editable;)V");
			global::android.text.method.TextKeyListener._getInstance8723 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.TextKeyListener.staticClass, "getInstance", "(ZLandroid/text/method/TextKeyListener$Capitalize;)Landroid/text/method/TextKeyListener;");
			global::android.text.method.TextKeyListener._getInstance8724 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.TextKeyListener.staticClass, "getInstance", "()Landroid/text/method/TextKeyListener;");
			global::android.text.method.TextKeyListener._release8725 = @__env.GetMethodIDNoThrow(global::android.text.method.TextKeyListener.staticClass, "release", "()V");
			global::android.text.method.TextKeyListener._onKeyDown8726 = @__env.GetMethodIDNoThrow(global::android.text.method.TextKeyListener.staticClass, "onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z");
			global::android.text.method.TextKeyListener._onKeyUp8727 = @__env.GetMethodIDNoThrow(global::android.text.method.TextKeyListener.staticClass, "onKeyUp", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z");
			global::android.text.method.TextKeyListener._getInputType8728 = @__env.GetMethodIDNoThrow(global::android.text.method.TextKeyListener.staticClass, "getInputType", "()I");
			global::android.text.method.TextKeyListener._onKeyOther8729 = @__env.GetMethodIDNoThrow(global::android.text.method.TextKeyListener.staticClass, "onKeyOther", "(Landroid/view/View;Landroid/text/Editable;Landroid/view/KeyEvent;)Z");
			global::android.text.method.TextKeyListener._onSpanAdded8730 = @__env.GetMethodIDNoThrow(global::android.text.method.TextKeyListener.staticClass, "onSpanAdded", "(Landroid/text/Spannable;Ljava/lang/Object;II)V");
			global::android.text.method.TextKeyListener._onSpanRemoved8731 = @__env.GetMethodIDNoThrow(global::android.text.method.TextKeyListener.staticClass, "onSpanRemoved", "(Landroid/text/Spannable;Ljava/lang/Object;II)V");
			global::android.text.method.TextKeyListener._onSpanChanged8732 = @__env.GetMethodIDNoThrow(global::android.text.method.TextKeyListener.staticClass, "onSpanChanged", "(Landroid/text/Spannable;Ljava/lang/Object;IIII)V");
			global::android.text.method.TextKeyListener._shouldCap8733 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.TextKeyListener.staticClass, "shouldCap", "(Landroid/text/method/TextKeyListener$Capitalize;Ljava/lang/CharSequence;I)Z");
			global::android.text.method.TextKeyListener._TextKeyListener8734 = @__env.GetMethodIDNoThrow(global::android.text.method.TextKeyListener.staticClass, "<init>", "(Landroid/text/method/TextKeyListener$Capitalize;Z)V");
		}
	}
}
