namespace android.text
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.text.SpannableStringInternal_))]
	public abstract partial class SpannableStringInternal : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SpannableStringInternal(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString12980;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.text.SpannableStringInternal.staticClass, "toString", "()Ljava/lang/String;", ref global::android.text.SpannableStringInternal._toString12980) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length12981;
		public virtual int length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.SpannableStringInternal.staticClass, "length", "()I", ref global::android.text.SpannableStringInternal._length12981);
		}
		internal static global::MonoJavaBridge.MethodId _charAt12982;
		public virtual char charAt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::android.text.SpannableStringInternal.staticClass, "charAt", "(I)C", ref global::android.text.SpannableStringInternal._charAt12982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChars12983;
		public virtual void getChars(int arg0, int arg1, char[] arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.SpannableStringInternal.staticClass, "getChars", "(II[CI)V", ref global::android.text.SpannableStringInternal._getChars12983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getSpans12984;
		public virtual global::java.lang.Object[] getSpans(int arg0, int arg1, java.lang.Class arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::android.text.SpannableStringInternal.staticClass, "getSpans", "(IILjava/lang/Class;)[Ljava/lang/Object;", ref global::android.text.SpannableStringInternal._getSpans12984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _getSpanStart12985;
		public virtual int getSpanStart(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.SpannableStringInternal.staticClass, "getSpanStart", "(Ljava/lang/Object;)I", ref global::android.text.SpannableStringInternal._getSpanStart12985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpanEnd12986;
		public virtual int getSpanEnd(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.SpannableStringInternal.staticClass, "getSpanEnd", "(Ljava/lang/Object;)I", ref global::android.text.SpannableStringInternal._getSpanEnd12986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpanFlags12987;
		public virtual int getSpanFlags(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.SpannableStringInternal.staticClass, "getSpanFlags", "(Ljava/lang/Object;)I", ref global::android.text.SpannableStringInternal._getSpanFlags12987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextSpanTransition12988;
		public virtual int nextSpanTransition(int arg0, int arg1, java.lang.Class arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.SpannableStringInternal.staticClass, "nextSpanTransition", "(IILjava/lang/Class;)I", ref global::android.text.SpannableStringInternal._nextSpanTransition12988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		static SpannableStringInternal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.SpannableStringInternal.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/SpannableStringInternal"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.SpannableStringInternal))]
	internal sealed partial class SpannableStringInternal_ : android.text.SpannableStringInternal
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SpannableStringInternal_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static SpannableStringInternal_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.SpannableStringInternal_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/SpannableStringInternal"));
		}
		internal static void InitJNI()
		{
		}
	}
}
