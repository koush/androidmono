namespace android.text
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.text.SpannableStringInternal_))]
	public abstract partial class SpannableStringInternal : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SpannableStringInternal()
		{
			InitJNI();
		}
		protected SpannableStringInternal(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString12919;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringInternal._toString12919)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringInternal.staticClass, global::android.text.SpannableStringInternal._toString12919)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length12920;
		public virtual int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.SpannableStringInternal._length12920);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.SpannableStringInternal.staticClass, global::android.text.SpannableStringInternal._length12920);
		}
		internal static global::MonoJavaBridge.MethodId _charAt12921;
		public virtual char charAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.text.SpannableStringInternal._charAt12921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.text.SpannableStringInternal.staticClass, global::android.text.SpannableStringInternal._charAt12921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChars12922;
		public virtual void getChars(int arg0, int arg1, char[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.SpannableStringInternal._getChars12922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.SpannableStringInternal.staticClass, global::android.text.SpannableStringInternal._getChars12922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getSpans12923;
		public virtual global::java.lang.Object[] getSpans(int arg0, int arg1, java.lang.Class arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.SpannableStringInternal._getSpans12923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.SpannableStringInternal.staticClass, global::android.text.SpannableStringInternal._getSpans12923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _getSpanStart12924;
		public virtual int getSpanStart(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.SpannableStringInternal._getSpanStart12924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.SpannableStringInternal.staticClass, global::android.text.SpannableStringInternal._getSpanStart12924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpanEnd12925;
		public virtual int getSpanEnd(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.SpannableStringInternal._getSpanEnd12925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.SpannableStringInternal.staticClass, global::android.text.SpannableStringInternal._getSpanEnd12925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpanFlags12926;
		public virtual int getSpanFlags(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.SpannableStringInternal._getSpanFlags12926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.SpannableStringInternal.staticClass, global::android.text.SpannableStringInternal._getSpanFlags12926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextSpanTransition12927;
		public virtual int nextSpanTransition(int arg0, int arg1, java.lang.Class arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.SpannableStringInternal._nextSpanTransition12927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.SpannableStringInternal.staticClass, global::android.text.SpannableStringInternal._nextSpanTransition12927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.SpannableStringInternal.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/SpannableStringInternal"));
			global::android.text.SpannableStringInternal._toString12919 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringInternal.staticClass, "toString", "()Ljava/lang/String;");
			global::android.text.SpannableStringInternal._length12920 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringInternal.staticClass, "length", "()I");
			global::android.text.SpannableStringInternal._charAt12921 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringInternal.staticClass, "charAt", "(I)C");
			global::android.text.SpannableStringInternal._getChars12922 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringInternal.staticClass, "getChars", "(II[CI)V");
			global::android.text.SpannableStringInternal._getSpans12923 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringInternal.staticClass, "getSpans", "(IILjava/lang/Class;)[Ljava/lang/Object;");
			global::android.text.SpannableStringInternal._getSpanStart12924 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringInternal.staticClass, "getSpanStart", "(Ljava/lang/Object;)I");
			global::android.text.SpannableStringInternal._getSpanEnd12925 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringInternal.staticClass, "getSpanEnd", "(Ljava/lang/Object;)I");
			global::android.text.SpannableStringInternal._getSpanFlags12926 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringInternal.staticClass, "getSpanFlags", "(Ljava/lang/Object;)I");
			global::android.text.SpannableStringInternal._nextSpanTransition12927 = @__env.GetMethodIDNoThrow(global::android.text.SpannableStringInternal.staticClass, "nextSpanTransition", "(IILjava/lang/Class;)I");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.SpannableStringInternal))]
	public sealed partial class SpannableStringInternal_ : android.text.SpannableStringInternal
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SpannableStringInternal_()
		{
			InitJNI();
		}
		internal SpannableStringInternal_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.SpannableStringInternal_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/SpannableStringInternal"));
		}
	}
}
