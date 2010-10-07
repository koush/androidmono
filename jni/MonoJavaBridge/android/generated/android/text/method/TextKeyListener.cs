namespace android.text.method
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class TextKeyListener : android.text.method.BaseKeyListener, SpanWatcher
	{
		internal new static global::java.lang.Class staticClass;
		static TextKeyListener()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.method.TextKeyListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.method.TextKeyListener(@__env);
			}
		}
		protected TextKeyListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class Capitalize : java.lang.Enum
		{
			internal new static global::java.lang.Class staticClass;
			static Capitalize()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.method.TextKeyListener.Capitalize), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.text.method.TextKeyListener.Capitalize(@__env);
				}
			}
			internal Capitalize(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _values7873;
			public static global::android.text.method.TextKeyListener.Capitalize[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.text.method.TextKeyListener.Capitalize.staticClass, global::android.text.method.TextKeyListener.Capitalize._values7873));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf7874;
			public static global::android.text.method.TextKeyListener.Capitalize valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.method.TextKeyListener.Capitalize>(@__env, @__env.CallStaticObjectMethodPtr(android.text.method.TextKeyListener.Capitalize.staticClass, global::android.text.method.TextKeyListener.Capitalize._valueOf7874, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _CHARACTERS7875;
			public static global::android.text.method.TextKeyListener.Capitalize CHARACTERS
			{
				get
				{
					return default(global::android.text.method.TextKeyListener.Capitalize);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _NONE7876;
			public static global::android.text.method.TextKeyListener.Capitalize NONE
			{
				get
				{
					return default(global::android.text.method.TextKeyListener.Capitalize);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _SENTENCES7877;
			public static global::android.text.method.TextKeyListener.Capitalize SENTENCES
			{
				get
				{
					return default(global::android.text.method.TextKeyListener.Capitalize);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _WORDS7878;
			public static global::android.text.method.TextKeyListener.Capitalize WORDS
			{
				get
				{
					return default(global::android.text.method.TextKeyListener.Capitalize);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.text.method.TextKeyListener.Capitalize.staticClass = @__class;
				global::android.text.method.TextKeyListener.Capitalize._values7873 = @__env.GetStaticMethodID(global::android.text.method.TextKeyListener.Capitalize.staticClass, "values", "()[Landroid/text/method/TextKeyListener/Capitalize;");
				global::android.text.method.TextKeyListener.Capitalize._valueOf7874 = @__env.GetStaticMethodID(global::android.text.method.TextKeyListener.Capitalize.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/text/method/TextKeyListener$Capitalize;");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _clear7879;
		public static void clear(android.text.Editable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._clear7879, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance7880;
		public static global::android.text.method.TextKeyListener getInstance(bool arg0, android.text.method.TextKeyListener.Capitalize arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.method.TextKeyListener>(@__env, @__env.CallStaticObjectMethodPtr(android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._getInstance7880, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance7881;
		public static global::android.text.method.TextKeyListener getInstance() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.method.TextKeyListener>(@__env, @__env.CallStaticObjectMethodPtr(android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._getInstance7881));
		}
		internal static global::net.sf.jni4net.jni.MethodId _release7882;
		public virtual void release() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.method.TextKeyListener._release7882);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._release7882);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown7883;
		public override bool onKeyDown(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.text.method.TextKeyListener._onKeyDown7883, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._onKeyDown7883, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp7884;
		public override bool onKeyUp(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.text.method.TextKeyListener._onKeyUp7884, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._onKeyUp7884, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInputType7885;
		public override int getInputType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.method.TextKeyListener._getInputType7885);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._getInputType7885);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onKeyOther7886;
		public override bool onKeyOther(android.view.View arg0, android.text.Editable arg1, android.view.KeyEvent arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.text.method.TextKeyListener._onKeyOther7886, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._onKeyOther7886, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSpanAdded7887;
		public virtual void onSpanAdded(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.method.TextKeyListener._onSpanAdded7887, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._onSpanAdded7887, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSpanRemoved7888;
		public virtual void onSpanRemoved(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.method.TextKeyListener._onSpanRemoved7888, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._onSpanRemoved7888, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onSpanChanged7889;
		public virtual void onSpanChanged(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3, int arg4, int arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.method.TextKeyListener._onSpanChanged7889, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._onSpanChanged7889, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _shouldCap7890;
		public static bool shouldCap(android.text.method.TextKeyListener.Capitalize arg0, java.lang.CharSequence arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._shouldCap7890, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _TextKeyListener7891;
		public TextKeyListener(android.text.method.TextKeyListener.Capitalize arg0, bool arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.method.TextKeyListener.staticClass, global::android.text.method.TextKeyListener._TextKeyListener7891, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.method.TextKeyListener.staticClass = @__class;
			global::android.text.method.TextKeyListener._clear7879 = @__env.GetStaticMethodID(global::android.text.method.TextKeyListener.staticClass, "clear", "(Landroid/text/Editable;)V");
			global::android.text.method.TextKeyListener._getInstance7880 = @__env.GetStaticMethodID(global::android.text.method.TextKeyListener.staticClass, "getInstance", "(ZLandroid/text/method/TextKeyListener$Capitalize;)Landroid/text/method/TextKeyListener;");
			global::android.text.method.TextKeyListener._getInstance7881 = @__env.GetStaticMethodID(global::android.text.method.TextKeyListener.staticClass, "getInstance", "()Landroid/text/method/TextKeyListener;");
			global::android.text.method.TextKeyListener._release7882 = @__env.GetMethodID(global::android.text.method.TextKeyListener.staticClass, "release", "()V");
			global::android.text.method.TextKeyListener._onKeyDown7883 = @__env.GetMethodID(global::android.text.method.TextKeyListener.staticClass, "onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z");
			global::android.text.method.TextKeyListener._onKeyUp7884 = @__env.GetMethodID(global::android.text.method.TextKeyListener.staticClass, "onKeyUp", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z");
			global::android.text.method.TextKeyListener._getInputType7885 = @__env.GetMethodID(global::android.text.method.TextKeyListener.staticClass, "getInputType", "()I");
			global::android.text.method.TextKeyListener._onKeyOther7886 = @__env.GetMethodID(global::android.text.method.TextKeyListener.staticClass, "onKeyOther", "(Landroid/view/View;Landroid/text/Editable;Landroid/view/KeyEvent;)Z");
			global::android.text.method.TextKeyListener._onSpanAdded7887 = @__env.GetMethodID(global::android.text.method.TextKeyListener.staticClass, "onSpanAdded", "(Landroid/text/Spannable;Ljava/lang/Object;II)V");
			global::android.text.method.TextKeyListener._onSpanRemoved7888 = @__env.GetMethodID(global::android.text.method.TextKeyListener.staticClass, "onSpanRemoved", "(Landroid/text/Spannable;Ljava/lang/Object;II)V");
			global::android.text.method.TextKeyListener._onSpanChanged7889 = @__env.GetMethodID(global::android.text.method.TextKeyListener.staticClass, "onSpanChanged", "(Landroid/text/Spannable;Ljava/lang/Object;IIII)V");
			global::android.text.method.TextKeyListener._shouldCap7890 = @__env.GetStaticMethodID(global::android.text.method.TextKeyListener.staticClass, "shouldCap", "(Landroid/text/method/TextKeyListener$Capitalize;Ljava/lang/CharSequence;I)Z");
			global::android.text.method.TextKeyListener._TextKeyListener7891 = @__env.GetMethodID(global::android.text.method.TextKeyListener.staticClass, "<init>", "(Landroid/text/method/TextKeyListener$Capitalize;Z)V");
		}
	}
}
