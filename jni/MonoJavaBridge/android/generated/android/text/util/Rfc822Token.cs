namespace android.text.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Rfc822Token : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Rfc822Token(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals13653;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.text.util.Rfc822Token._equals13653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._equals13653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString13654;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.util.Rfc822Token._toString13654)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._toString13654)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode13655;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.util.Rfc822Token._hashCode13655);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._hashCode13655);
		}
		public new global::java.lang.String Address
		{
			get
			{
				return getAddress();
			}
			set
			{
				setAddress(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAddress13656;
		public virtual global::java.lang.String getAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.util.Rfc822Token._getAddress13656)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._getAddress13656)) as java.lang.String;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
			set
			{
				setName(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName13657;
		public virtual global::java.lang.String getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.util.Rfc822Token._getName13657)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._getName13657)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setName13658;
		public virtual void setName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.util.Rfc822Token._setName13658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._setName13658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setComment13659;
		public virtual void setComment(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.util.Rfc822Token._setComment13659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._setComment13659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Comment
		{
			get
			{
				return getComment();
			}
			set
			{
				setComment(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getComment13660;
		public virtual global::java.lang.String getComment()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.util.Rfc822Token._getComment13660)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._getComment13660)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setAddress13661;
		public virtual void setAddress(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.util.Rfc822Token._setAddress13661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._setAddress13661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _quoteNameIfNecessary13662;
		public static global::java.lang.String quoteNameIfNecessary(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._quoteNameIfNecessary13662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _quoteName13663;
		public static global::java.lang.String quoteName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._quoteName13663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _quoteComment13664;
		public static global::java.lang.String quoteComment(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._quoteComment13664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _Rfc822Token13665;
		public Rfc822Token(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.util.Rfc822Token.staticClass, global::android.text.util.Rfc822Token._Rfc822Token13665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static Rfc822Token()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.util.Rfc822Token.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/util/Rfc822Token"));
			global::android.text.util.Rfc822Token._equals13653 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.text.util.Rfc822Token._toString13654 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "toString", "()Ljava/lang/String;");
			global::android.text.util.Rfc822Token._hashCode13655 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "hashCode", "()I");
			global::android.text.util.Rfc822Token._getAddress13656 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "getAddress", "()Ljava/lang/String;");
			global::android.text.util.Rfc822Token._getName13657 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "getName", "()Ljava/lang/String;");
			global::android.text.util.Rfc822Token._setName13658 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "setName", "(Ljava/lang/String;)V");
			global::android.text.util.Rfc822Token._setComment13659 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "setComment", "(Ljava/lang/String;)V");
			global::android.text.util.Rfc822Token._getComment13660 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "getComment", "()Ljava/lang/String;");
			global::android.text.util.Rfc822Token._setAddress13661 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "setAddress", "(Ljava/lang/String;)V");
			global::android.text.util.Rfc822Token._quoteNameIfNecessary13662 = @__env.GetStaticMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "quoteNameIfNecessary", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.text.util.Rfc822Token._quoteName13663 = @__env.GetStaticMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "quoteName", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.text.util.Rfc822Token._quoteComment13664 = @__env.GetStaticMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "quoteComment", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.text.util.Rfc822Token._Rfc822Token13665 = @__env.GetMethodIDNoThrow(global::android.text.util.Rfc822Token.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
