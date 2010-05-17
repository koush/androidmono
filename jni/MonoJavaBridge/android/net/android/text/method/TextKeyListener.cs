namespace android.text.method 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class TextKeyListener : android.text.method.BaseKeyListener, SpanWatcher
	{ 
		internal new static global::java.lang.Class staticClass; 
		static TextKeyListener() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.method.TextKeyListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.method.TextKeyListener.Capitalize), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _valueOf6879; 
			public static android.text.method.TextKeyListener.Capitalize valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.method.TextKeyListener.Capitalize>(@__env, @__env.CallStaticObjectMethodPtr(android.text.method.TextKeyListener.Capitalize.staticClass, _valueOf6879, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values6880; 
			public static android.text.method.TextKeyListener.Capitalize[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.text.method.TextKeyListener.Capitalize.staticClass, _values6880)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CHARACTERS6881; 
			public static android.text.method.TextKeyListener.Capitalize CHARACTERS
			{ 
				get 
				{ 
					return default(android.text.method.TextKeyListener.Capitalize); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _NONE6882; 
			public static android.text.method.TextKeyListener.Capitalize NONE
			{ 
				get 
				{ 
					return default(android.text.method.TextKeyListener.Capitalize); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _SENTENCES6883; 
			public static android.text.method.TextKeyListener.Capitalize SENTENCES
			{ 
				get 
				{ 
					return default(android.text.method.TextKeyListener.Capitalize); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _WORDS6884; 
			public static android.text.method.TextKeyListener.Capitalize WORDS
			{ 
				get 
				{ 
					return default(android.text.method.TextKeyListener.Capitalize); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.text.method.TextKeyListener.Capitalize.staticClass = @__class; 
				global::android.text.method.TextKeyListener.Capitalize._valueOf6879 = @__env.GetStaticMethodID(global::android.text.method.TextKeyListener.Capitalize.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/text/method/TextKeyListener$Capitalize;"); 
				global::android.text.method.TextKeyListener.Capitalize._values6880 = @__env.GetStaticMethodID(global::android.text.method.TextKeyListener.Capitalize.staticClass, "values", "()[Landroid/text/method/TextKeyListener/Capitalize;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear6885; 
		public static void clear(android.text.Editable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.text.method.TextKeyListener.staticClass, _clear6885, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance6886; 
		public static android.text.method.TextKeyListener getInstance(bool arg0, android.text.method.TextKeyListener.Capitalize arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.method.TextKeyListener>(@__env, @__env.CallStaticObjectMethodPtr(android.text.method.TextKeyListener.staticClass, _getInstance6886, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance6887; 
		public static android.text.method.TextKeyListener getInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.method.TextKeyListener>(@__env, @__env.CallStaticObjectMethodPtr(android.text.method.TextKeyListener.staticClass, _getInstance6887)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _release6888; 
		public virtual void release() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.TextKeyListener)) 
				@__env.CallVoidMethod(this, _release6888); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.method.TextKeyListener.staticClass, _release6888); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyDown6889; 
		public override bool onKeyDown(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.TextKeyListener)) 
				return @__env.CallBooleanMethod(this, _onKeyDown6889, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.method.TextKeyListener.staticClass, _onKeyDown6889, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyUp6890; 
		public override bool onKeyUp(android.view.View arg0, android.text.Editable arg1, int arg2, android.view.KeyEvent arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.TextKeyListener)) 
				return @__env.CallBooleanMethod(this, _onKeyUp6890, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.method.TextKeyListener.staticClass, _onKeyUp6890, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInputType6891; 
		public override int getInputType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.TextKeyListener)) 
				return @__env.CallIntMethod(this, _getInputType6891); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.method.TextKeyListener.staticClass, _getInputType6891); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onKeyOther6892; 
		public override bool onKeyOther(android.view.View arg0, android.text.Editable arg1, android.view.KeyEvent arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.TextKeyListener)) 
				return @__env.CallBooleanMethod(this, _onKeyOther6892, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.method.TextKeyListener.staticClass, _onKeyOther6892, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSpanAdded6893; 
		public virtual void onSpanAdded(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.TextKeyListener)) 
				@__env.CallVoidMethod(this, _onSpanAdded6893, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.method.TextKeyListener.staticClass, _onSpanAdded6893, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSpanRemoved6894; 
		public virtual void onSpanRemoved(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.TextKeyListener)) 
				@__env.CallVoidMethod(this, _onSpanRemoved6894, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.method.TextKeyListener.staticClass, _onSpanRemoved6894, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSpanChanged6895; 
		public virtual void onSpanChanged(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3, int arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.TextKeyListener)) 
				@__env.CallVoidMethod(this, _onSpanChanged6895, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.method.TextKeyListener.staticClass, _onSpanChanged6895, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _shouldCap6896; 
		public static bool shouldCap(android.text.method.TextKeyListener.Capitalize arg0, java.lang.CharSequence arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.text.method.TextKeyListener.staticClass, _shouldCap6896, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TextKeyListener6897; 
		public TextKeyListener(android.text.method.TextKeyListener.Capitalize arg0, bool arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.method.TextKeyListener.staticClass, _TextKeyListener6897, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.method.TextKeyListener.staticClass = @__class; 
			global::android.text.method.TextKeyListener._clear6885 = @__env.GetStaticMethodID(global::android.text.method.TextKeyListener.staticClass, "clear", "(Landroid/text/Editable;)V"); 
			global::android.text.method.TextKeyListener._getInstance6886 = @__env.GetStaticMethodID(global::android.text.method.TextKeyListener.staticClass, "getInstance", "(ZLandroid/text/method/TextKeyListener$Capitalize;)Landroid/text/method/TextKeyListener;"); 
			global::android.text.method.TextKeyListener._getInstance6887 = @__env.GetStaticMethodID(global::android.text.method.TextKeyListener.staticClass, "getInstance", "()Landroid/text/method/TextKeyListener;"); 
			global::android.text.method.TextKeyListener._release6888 = @__env.GetMethodID(global::android.text.method.TextKeyListener.staticClass, "release", "()V"); 
			global::android.text.method.TextKeyListener._onKeyDown6889 = @__env.GetMethodID(global::android.text.method.TextKeyListener.staticClass, "onKeyDown", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z"); 
			global::android.text.method.TextKeyListener._onKeyUp6890 = @__env.GetMethodID(global::android.text.method.TextKeyListener.staticClass, "onKeyUp", "(Landroid/view/View;Landroid/text/Editable;ILandroid/view/KeyEvent;)Z"); 
			global::android.text.method.TextKeyListener._getInputType6891 = @__env.GetMethodID(global::android.text.method.TextKeyListener.staticClass, "getInputType", "()I"); 
			global::android.text.method.TextKeyListener._onKeyOther6892 = @__env.GetMethodID(global::android.text.method.TextKeyListener.staticClass, "onKeyOther", "(Landroid/view/View;Landroid/text/Editable;Landroid/view/KeyEvent;)Z"); 
			global::android.text.method.TextKeyListener._onSpanAdded6893 = @__env.GetMethodID(global::android.text.method.TextKeyListener.staticClass, "onSpanAdded", "(Landroid/text/Spannable;Ljava/lang/Object;II)V"); 
			global::android.text.method.TextKeyListener._onSpanRemoved6894 = @__env.GetMethodID(global::android.text.method.TextKeyListener.staticClass, "onSpanRemoved", "(Landroid/text/Spannable;Ljava/lang/Object;II)V"); 
			global::android.text.method.TextKeyListener._onSpanChanged6895 = @__env.GetMethodID(global::android.text.method.TextKeyListener.staticClass, "onSpanChanged", "(Landroid/text/Spannable;Ljava/lang/Object;IIII)V"); 
			global::android.text.method.TextKeyListener._shouldCap6896 = @__env.GetStaticMethodID(global::android.text.method.TextKeyListener.staticClass, "shouldCap", "(Landroid/text/method/TextKeyListener$Capitalize;Ljava/lang/CharSequence;I)Z"); 
			global::android.text.method.TextKeyListener._TextKeyListener6897 = @__env.GetMethodID(global::android.text.method.TextKeyListener.staticClass, "<init>", "(Landroid/text/method/TextKeyListener$Capitalize;Z)V"); 
		} 
	} 
} 
