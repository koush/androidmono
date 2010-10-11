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
			internal static global::MonoJavaBridge.MethodId _values8170;
			public static global::android.text.method.TextKeyListener.Capitalize[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.text.method.TextKeyListener.Capitalize>(@__env.CallStaticObjectMethod(android.text.method.TextKeyListener.Capitalize.staticClass, global::android.text.method.TextKeyListener.Capitalize._values8170)) as android.text.method.TextKeyListener.Capitalize[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf8171;
			public static global::android.text.method.TextKeyListener.Capitalize valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.TextKeyListener.Capitalize.staticClass, global::android.text.method.TextKeyListener.Capitalize._valueOf8171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.method.TextKeyListener.Capitalize;
			}
			internal static global::MonoJavaBridge.FieldId _CHARACTERS8172;
			public static global::android.text.method.TextKeyListener.Capitalize CHARACTERS
			{
				get
				{
					return default(global::android.text.method.TextKeyListener.Capitalize);
				}
			}
			internal static global::MonoJavaBridge.FieldId _NONE8173;
			public static global::android.text.method.TextKeyListener.Capitalize NONE
			{
				get
				{
					return default(global::android.text.method.TextKeyListener.Capitalize);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SENTENCES8174;
			public static global::android.text.method.TextKeyListener.Capitalize SENTENCES
			{
				get
				{
					return default(global::android.text.method.TextKeyListener.Capitalize);
				}
			}
			internal static global::MonoJavaBridge.FieldId _WORDS8175;
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
				global::android.text.method.TextKeyListener.Capitalize._values8170 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.TextKeyListener.Capitalize.staticClass, "values", "()[Landroid/text/method/TextKeyListener/Capitalize;");
				global::android.text.method.TextKeyListener.Capitalize._valueOf8171 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.TextKeyListener.Capitalize.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/text/method/TextKeyListener$Capitalize;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _clear8176;
		public static void clear(android.text.Editable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._clear8176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInstance8177;
		public static global::android.text.method.TextKeyListener getInstance(bool arg0, android.text.method.TextKeyListener.Capitalize arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._getInstance8177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.text.method.TextKeyListener;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance8178;
		public static global::android.text.method.TextKeyListener getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._getInstance8178)) as android.text.method.TextKeyListener;
		}
		internal static global::MonoJavaBridge.MethodId _release8179;
		public virtual void release() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.method.TextKeyListener._release8179);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._release8179);
		}
		internal static global::MonoJavaBridge.MethodId _onKeyDown8180;
		public override bool onKeyDown(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.TextKeyListener._onKeyDown8180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._onKeyDown8180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onKeyUp8181;
		public override bool onKeyUp(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.TextKeyListener._onKeyUp8181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._onKeyUp8181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getInputType8182;
		public override int getInputType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.method.TextKeyListener._getInputType8182);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._getInputType8182);
		}
		internal static global::MonoJavaBridge.MethodId _onKeyOther8183;
		public override bool onKeyOther(android.view.View arg0, android.text.Editable arg1, android.view.KeyEvent arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.method.TextKeyListener._onKeyOther8183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._onKeyOther8183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onSpanAdded8184;
		public virtual void onSpanAdded(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.method.TextKeyListener._onSpanAdded8184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._onSpanAdded8184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onSpanRemoved8185;
		public virtual void onSpanRemoved(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.method.TextKeyListener._onSpanRemoved8185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._onSpanRemoved8185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _onSpanChanged8186;
		public virtual void onSpanChanged(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.method.TextKeyListener._onSpanChanged8186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._onSpanChanged8186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _shouldCap8187;
		public static bool shouldCap(android.text.method.TextKeyListener.Capitalize arg0, java.lang.CharSequence arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._shouldCap8187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _TextKeyListener8188;
		public TextKeyListener(android.text.method.TextKeyListener.Capitalize arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._TextKeyListener8188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.method.TextKeyListener.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/method/TextKeyListener"));
			global::android.text.method.TextKeyListener._clear8176 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.TextKeyListener.staticClass, "clear", "(Landroid/text/Editable;)V");
			global::android.text.method.TextKeyListener._getInstance8177 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.TextKeyListener.staticClass, "getInstance", "(ZLandroid/text/method/TextKeyListener$Capitalize;)Landroid/text/method/TextKeyListener;");
			global::android.text.method.TextKeyListener._getInstance8178 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.TextKeyListener.staticClass, "getInstance", "()Landroid/text/method/TextKeyListener;");
			global::android.text.method.TextKeyListener._release8179 = @__env.GetMethodIDNoThrow(global::android.text.method.TextKeyListener.staticClass, "release", "()V");
			global::android.text.method.TextKeyListener._onKeyDown8180 = @__env.GetMethodIDNoThrow(global::android.text.method.TextKeyListener.staticClass, "onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z");
			global::android.text.method.TextKeyListener._onKeyUp8181 = @__env.GetMethodIDNoThrow(global::android.text.method.TextKeyListener.staticClass, "onKeyUp", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z");
			global::android.text.method.TextKeyListener._getInputType8182 = @__env.GetMethodIDNoThrow(global::android.text.method.TextKeyListener.staticClass, "getInputType", "()I");
			global::android.text.method.TextKeyListener._onKeyOther8183 = @__env.GetMethodIDNoThrow(global::android.text.method.TextKeyListener.staticClass, "onKeyOther", "(Landroid/view/View;Landroid/text/Editable;Landroid/view/KeyEvent;)Z");
			global::android.text.method.TextKeyListener._onSpanAdded8184 = @__env.GetMethodIDNoThrow(global::android.text.method.TextKeyListener.staticClass, "onSpanAdded", "(Landroid/text/Spannable;Ljava/lang/Object;II)V");
			global::android.text.method.TextKeyListener._onSpanRemoved8185 = @__env.GetMethodIDNoThrow(global::android.text.method.TextKeyListener.staticClass, "onSpanRemoved", "(Landroid/text/Spannable;Ljava/lang/Object;II)V");
			global::android.text.method.TextKeyListener._onSpanChanged8186 = @__env.GetMethodIDNoThrow(global::android.text.method.TextKeyListener.staticClass, "onSpanChanged", "(Landroid/text/Spannable;Ljava/lang/Object;IIII)V");
			global::android.text.method.TextKeyListener._shouldCap8187 = @__env.GetStaticMethodIDNoThrow(global::android.text.method.TextKeyListener.staticClass, "shouldCap", "(Landroid/text/method/TextKeyListener$Capitalize;Ljava/lang/CharSequence;I)Z");
			global::android.text.method.TextKeyListener._TextKeyListener8188 = @__env.GetMethodIDNoThrow(global::android.text.method.TextKeyListener.staticClass, "<init>", "(Landroid/text/method/TextKeyListener$Capitalize;Z)V");
		}
	}
}
