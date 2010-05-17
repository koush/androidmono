namespace android.text 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class LoginFilter : java.lang.Object, InputFilter
	{ 
		internal static global::java.lang.Class staticClass; 
		static LoginFilter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.LoginFilter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected LoginFilter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class PasswordFilterGMail : android.text.LoginFilter
		{ 
			internal new static global::java.lang.Class staticClass; 
			static PasswordFilterGMail() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.LoginFilter.PasswordFilterGMail), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.text.LoginFilter.PasswordFilterGMail(@__env); 
				} 
			} 
			protected PasswordFilterGMail(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _isAllowed6520; 
			public override bool isAllowed(char arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.text.LoginFilter.PasswordFilterGMail)) 
					return @__env.CallBooleanMethod(this, _isAllowed6520, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.text.LoginFilter.PasswordFilterGMail.staticClass, _isAllowed6520, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _PasswordFilterGMail6521; 
			public PasswordFilterGMail()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.text.LoginFilter.PasswordFilterGMail.staticClass, _PasswordFilterGMail6521, this); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _PasswordFilterGMail6522; 
			public PasswordFilterGMail(bool arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.text.LoginFilter.PasswordFilterGMail.staticClass, _PasswordFilterGMail6522, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.text.LoginFilter.PasswordFilterGMail.staticClass = @__class; 
				global::android.text.LoginFilter.PasswordFilterGMail._isAllowed6520 = @__env.GetMethodID(global::android.text.LoginFilter.PasswordFilterGMail.staticClass, "isAllowed", "(C)Z"); 
				global::android.text.LoginFilter.PasswordFilterGMail._PasswordFilterGMail6521 = @__env.GetMethodID(global::android.text.LoginFilter.PasswordFilterGMail.staticClass, "<init>", "()V"); 
				global::android.text.LoginFilter.PasswordFilterGMail._PasswordFilterGMail6522 = @__env.GetMethodID(global::android.text.LoginFilter.PasswordFilterGMail.staticClass, "<init>", "(Z)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class UsernameFilterGMail : android.text.LoginFilter
		{ 
			internal new static global::java.lang.Class staticClass; 
			static UsernameFilterGMail() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.LoginFilter.UsernameFilterGMail), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.text.LoginFilter.UsernameFilterGMail(@__env); 
				} 
			} 
			protected UsernameFilterGMail(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _isAllowed6523; 
			public override bool isAllowed(char arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.text.LoginFilter.UsernameFilterGMail)) 
					return @__env.CallBooleanMethod(this, _isAllowed6523, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.text.LoginFilter.UsernameFilterGMail.staticClass, _isAllowed6523, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _UsernameFilterGMail6524; 
			public UsernameFilterGMail()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.text.LoginFilter.UsernameFilterGMail.staticClass, _UsernameFilterGMail6524, this); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _UsernameFilterGMail6525; 
			public UsernameFilterGMail(bool arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.text.LoginFilter.UsernameFilterGMail.staticClass, _UsernameFilterGMail6525, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.text.LoginFilter.UsernameFilterGMail.staticClass = @__class; 
				global::android.text.LoginFilter.UsernameFilterGMail._isAllowed6523 = @__env.GetMethodID(global::android.text.LoginFilter.UsernameFilterGMail.staticClass, "isAllowed", "(C)Z"); 
				global::android.text.LoginFilter.UsernameFilterGMail._UsernameFilterGMail6524 = @__env.GetMethodID(global::android.text.LoginFilter.UsernameFilterGMail.staticClass, "<init>", "()V"); 
				global::android.text.LoginFilter.UsernameFilterGMail._UsernameFilterGMail6525 = @__env.GetMethodID(global::android.text.LoginFilter.UsernameFilterGMail.staticClass, "<init>", "(Z)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class UsernameFilterGeneric : android.text.LoginFilter
		{ 
			internal new static global::java.lang.Class staticClass; 
			static UsernameFilterGeneric() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.LoginFilter.UsernameFilterGeneric), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.text.LoginFilter.UsernameFilterGeneric(@__env); 
				} 
			} 
			protected UsernameFilterGeneric(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _isAllowed6526; 
			public override bool isAllowed(char arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.text.LoginFilter.UsernameFilterGeneric)) 
					return @__env.CallBooleanMethod(this, _isAllowed6526, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.text.LoginFilter.UsernameFilterGeneric.staticClass, _isAllowed6526, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _UsernameFilterGeneric6527; 
			public UsernameFilterGeneric()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.text.LoginFilter.UsernameFilterGeneric.staticClass, _UsernameFilterGeneric6527, this); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _UsernameFilterGeneric6528; 
			public UsernameFilterGeneric(bool arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.text.LoginFilter.UsernameFilterGeneric.staticClass, _UsernameFilterGeneric6528, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.text.LoginFilter.UsernameFilterGeneric.staticClass = @__class; 
				global::android.text.LoginFilter.UsernameFilterGeneric._isAllowed6526 = @__env.GetMethodID(global::android.text.LoginFilter.UsernameFilterGeneric.staticClass, "isAllowed", "(C)Z"); 
				global::android.text.LoginFilter.UsernameFilterGeneric._UsernameFilterGeneric6527 = @__env.GetMethodID(global::android.text.LoginFilter.UsernameFilterGeneric.staticClass, "<init>", "()V"); 
				global::android.text.LoginFilter.UsernameFilterGeneric._UsernameFilterGeneric6528 = @__env.GetMethodID(global::android.text.LoginFilter.UsernameFilterGeneric.staticClass, "<init>", "(Z)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _filter6529; 
		public virtual java.lang.CharSequence filter(java.lang.CharSequence arg0, int arg1, int arg2, android.text.Spanned arg3, int arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.LoginFilter)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, _filter6529, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.LoginFilter.staticClass, _filter6529, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStart6530; 
		public virtual void onStart() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.LoginFilter)) 
				@__env.CallVoidMethod(this, _onStart6530); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.LoginFilter.staticClass, _onStart6530); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStop6531; 
		public virtual void onStop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.LoginFilter)) 
				@__env.CallVoidMethod(this, _onStop6531); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.LoginFilter.staticClass, _onStop6531); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAllowed6532; 
		public abstract bool isAllowed(char arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _onInvalidCharacter6533; 
		public virtual void onInvalidCharacter(char arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.LoginFilter)) 
				@__env.CallVoidMethod(this, _onInvalidCharacter6533, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.LoginFilter.staticClass, _onInvalidCharacter6533, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.LoginFilter.staticClass = @__class; 
			global::android.text.LoginFilter._filter6529 = @__env.GetMethodID(global::android.text.LoginFilter.staticClass, "filter", "(Ljava/lang/CharSequence;IILandroid/text/Spanned;II)Ljava/lang/CharSequence;"); 
			global::android.text.LoginFilter._onStart6530 = @__env.GetMethodID(global::android.text.LoginFilter.staticClass, "onStart", "()V"); 
			global::android.text.LoginFilter._onStop6531 = @__env.GetMethodID(global::android.text.LoginFilter.staticClass, "onStop", "()V"); 
			global::android.text.LoginFilter._isAllowed6532 = @__env.GetMethodID(global::android.text.LoginFilter.staticClass, "isAllowed", "(C)Z"); 
			global::android.text.LoginFilter._onInvalidCharacter6533 = @__env.GetMethodID(global::android.text.LoginFilter.staticClass, "onInvalidCharacter", "(C)V"); 
		} 
	} 
} 
