namespace android.text
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.text.LoginFilter_))]
	public abstract partial class LoginFilter : java.lang.Object, InputFilter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LoginFilter()
		{
			InitJNI();
		}
		protected LoginFilter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class PasswordFilterGMail : android.text.LoginFilter
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static PasswordFilterGMail()
			{
				InitJNI();
			}
			protected PasswordFilterGMail(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _isAllowed12826;
			public override bool isAllowed(char arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.LoginFilter.PasswordFilterGMail._isAllowed12826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.LoginFilter.PasswordFilterGMail.staticClass, global::android.text.LoginFilter.PasswordFilterGMail._isAllowed12826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _PasswordFilterGMail12827;
			public PasswordFilterGMail()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.LoginFilter.PasswordFilterGMail.staticClass, global::android.text.LoginFilter.PasswordFilterGMail._PasswordFilterGMail12827);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _PasswordFilterGMail12828;
			public PasswordFilterGMail(bool arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.LoginFilter.PasswordFilterGMail.staticClass, global::android.text.LoginFilter.PasswordFilterGMail._PasswordFilterGMail12828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.LoginFilter.PasswordFilterGMail.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/LoginFilter$PasswordFilterGMail"));
				global::android.text.LoginFilter.PasswordFilterGMail._isAllowed12826 = @__env.GetMethodIDNoThrow(global::android.text.LoginFilter.PasswordFilterGMail.staticClass, "isAllowed", "(C)Z");
				global::android.text.LoginFilter.PasswordFilterGMail._PasswordFilterGMail12827 = @__env.GetMethodIDNoThrow(global::android.text.LoginFilter.PasswordFilterGMail.staticClass, "<init>", "()V");
				global::android.text.LoginFilter.PasswordFilterGMail._PasswordFilterGMail12828 = @__env.GetMethodIDNoThrow(global::android.text.LoginFilter.PasswordFilterGMail.staticClass, "<init>", "(Z)V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class UsernameFilterGMail : android.text.LoginFilter
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static UsernameFilterGMail()
			{
				InitJNI();
			}
			protected UsernameFilterGMail(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _isAllowed12829;
			public override bool isAllowed(char arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.LoginFilter.UsernameFilterGMail._isAllowed12829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.LoginFilter.UsernameFilterGMail.staticClass, global::android.text.LoginFilter.UsernameFilterGMail._isAllowed12829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _UsernameFilterGMail12830;
			public UsernameFilterGMail()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.LoginFilter.UsernameFilterGMail.staticClass, global::android.text.LoginFilter.UsernameFilterGMail._UsernameFilterGMail12830);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _UsernameFilterGMail12831;
			public UsernameFilterGMail(bool arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.LoginFilter.UsernameFilterGMail.staticClass, global::android.text.LoginFilter.UsernameFilterGMail._UsernameFilterGMail12831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.LoginFilter.UsernameFilterGMail.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/LoginFilter$UsernameFilterGMail"));
				global::android.text.LoginFilter.UsernameFilterGMail._isAllowed12829 = @__env.GetMethodIDNoThrow(global::android.text.LoginFilter.UsernameFilterGMail.staticClass, "isAllowed", "(C)Z");
				global::android.text.LoginFilter.UsernameFilterGMail._UsernameFilterGMail12830 = @__env.GetMethodIDNoThrow(global::android.text.LoginFilter.UsernameFilterGMail.staticClass, "<init>", "()V");
				global::android.text.LoginFilter.UsernameFilterGMail._UsernameFilterGMail12831 = @__env.GetMethodIDNoThrow(global::android.text.LoginFilter.UsernameFilterGMail.staticClass, "<init>", "(Z)V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class UsernameFilterGeneric : android.text.LoginFilter
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static UsernameFilterGeneric()
			{
				InitJNI();
			}
			protected UsernameFilterGeneric(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _isAllowed12832;
			public override bool isAllowed(char arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.LoginFilter.UsernameFilterGeneric._isAllowed12832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.LoginFilter.UsernameFilterGeneric.staticClass, global::android.text.LoginFilter.UsernameFilterGeneric._isAllowed12832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _UsernameFilterGeneric12833;
			public UsernameFilterGeneric()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.LoginFilter.UsernameFilterGeneric.staticClass, global::android.text.LoginFilter.UsernameFilterGeneric._UsernameFilterGeneric12833);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _UsernameFilterGeneric12834;
			public UsernameFilterGeneric(bool arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.LoginFilter.UsernameFilterGeneric.staticClass, global::android.text.LoginFilter.UsernameFilterGeneric._UsernameFilterGeneric12834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.LoginFilter.UsernameFilterGeneric.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/LoginFilter$UsernameFilterGeneric"));
				global::android.text.LoginFilter.UsernameFilterGeneric._isAllowed12832 = @__env.GetMethodIDNoThrow(global::android.text.LoginFilter.UsernameFilterGeneric.staticClass, "isAllowed", "(C)Z");
				global::android.text.LoginFilter.UsernameFilterGeneric._UsernameFilterGeneric12833 = @__env.GetMethodIDNoThrow(global::android.text.LoginFilter.UsernameFilterGeneric.staticClass, "<init>", "()V");
				global::android.text.LoginFilter.UsernameFilterGeneric._UsernameFilterGeneric12834 = @__env.GetMethodIDNoThrow(global::android.text.LoginFilter.UsernameFilterGeneric.staticClass, "<init>", "(Z)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _filter12835;
		public virtual global::java.lang.CharSequence filter(java.lang.CharSequence arg0, int arg1, int arg2, android.text.Spanned arg3, int arg4, int arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.LoginFilter._filter12835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.LoginFilter.staticClass, global::android.text.LoginFilter._filter12835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as java.lang.CharSequence;
		}
		public java.lang.CharSequence filter(string arg0, int arg1, int arg2, android.text.Spanned arg3, int arg4, int arg5)
		{
			return filter((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3, arg4, arg5);
		}
		internal static global::MonoJavaBridge.MethodId _onStart12836;
		public virtual void onStart() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.LoginFilter._onStart12836);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.LoginFilter.staticClass, global::android.text.LoginFilter._onStart12836);
		}
		internal static global::MonoJavaBridge.MethodId _onStop12837;
		public virtual void onStop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.LoginFilter._onStop12837);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.LoginFilter.staticClass, global::android.text.LoginFilter._onStop12837);
		}
		internal static global::MonoJavaBridge.MethodId _isAllowed12838;
		public abstract bool isAllowed(char arg0);
		internal static global::MonoJavaBridge.MethodId _onInvalidCharacter12839;
		public virtual void onInvalidCharacter(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.LoginFilter._onInvalidCharacter12839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.LoginFilter.staticClass, global::android.text.LoginFilter._onInvalidCharacter12839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.LoginFilter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/LoginFilter"));
			global::android.text.LoginFilter._filter12835 = @__env.GetMethodIDNoThrow(global::android.text.LoginFilter.staticClass, "filter", "(Ljava/lang/CharSequence;IILandroid/text/Spanned;II)Ljava/lang/CharSequence;");
			global::android.text.LoginFilter._onStart12836 = @__env.GetMethodIDNoThrow(global::android.text.LoginFilter.staticClass, "onStart", "()V");
			global::android.text.LoginFilter._onStop12837 = @__env.GetMethodIDNoThrow(global::android.text.LoginFilter.staticClass, "onStop", "()V");
			global::android.text.LoginFilter._isAllowed12838 = @__env.GetMethodIDNoThrow(global::android.text.LoginFilter.staticClass, "isAllowed", "(C)Z");
			global::android.text.LoginFilter._onInvalidCharacter12839 = @__env.GetMethodIDNoThrow(global::android.text.LoginFilter.staticClass, "onInvalidCharacter", "(C)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.LoginFilter))]
	public sealed partial class LoginFilter_ : android.text.LoginFilter
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LoginFilter_()
		{
			InitJNI();
		}
		internal LoginFilter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isAllowed12840;
		public override bool isAllowed(char arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.LoginFilter_._isAllowed12840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.LoginFilter_.staticClass, global::android.text.LoginFilter_._isAllowed12840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.LoginFilter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/LoginFilter"));
			global::android.text.LoginFilter_._isAllowed12840 = @__env.GetMethodIDNoThrow(global::android.text.LoginFilter_.staticClass, "isAllowed", "(C)Z");
		}
	}
}
