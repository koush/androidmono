namespace android.text
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.Spanned_))]
	public interface Spanned : java.lang.CharSequence
	{
		global::java.lang.Object[] getSpans(int arg0, int arg1, java.lang.Class arg2);
		int getSpanStart(java.lang.Object arg0);
		int getSpanEnd(java.lang.Object arg0);
		int getSpanFlags(java.lang.Object arg0);
		int nextSpanTransition(int arg0, int arg1, java.lang.Class arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.Spanned))]
	public sealed partial class Spanned_ : java.lang.Object, Spanned
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Spanned_()
		{
			InitJNI();
		}
		internal Spanned_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getSpans7862;
		 global::java.lang.Object[] android.text.Spanned.getSpans(int arg0, int arg1, java.lang.Class arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Spanned_._getSpans7862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Spanned_.staticClass, global::android.text.Spanned_._getSpans7862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _getSpanStart7863;
		 int android.text.Spanned.getSpanStart(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Spanned_._getSpanStart7863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Spanned_.staticClass, global::android.text.Spanned_._getSpanStart7863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpanEnd7864;
		 int android.text.Spanned.getSpanEnd(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Spanned_._getSpanEnd7864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Spanned_.staticClass, global::android.text.Spanned_._getSpanEnd7864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpanFlags7865;
		 int android.text.Spanned.getSpanFlags(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Spanned_._getSpanFlags7865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Spanned_.staticClass, global::android.text.Spanned_._getSpanFlags7865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextSpanTransition7866;
		 int android.text.Spanned.nextSpanTransition(int arg0, int arg1, java.lang.Class arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Spanned_._nextSpanTransition7866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Spanned_.staticClass, global::android.text.Spanned_._nextSpanTransition7866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _toString7867;
		 global::java.lang.String java.lang.CharSequence.toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Spanned_._toString7867)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Spanned_.staticClass, global::android.text.Spanned_._toString7867)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length7868;
		 int java.lang.CharSequence.length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Spanned_._length7868);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Spanned_.staticClass, global::android.text.Spanned_._length7868);
		}
		internal static global::MonoJavaBridge.MethodId _charAt7869;
		 char java.lang.CharSequence.charAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.text.Spanned_._charAt7869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.text.Spanned_.staticClass, global::android.text.Spanned_._charAt7869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _subSequence7870;
		 global::java.lang.CharSequence java.lang.CharSequence.subSequence(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Spanned_._subSequence7870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Spanned_.staticClass, global::android.text.Spanned_._subSequence7870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.Spanned_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Spanned"));
			global::android.text.Spanned_._getSpans7862 = @__env.GetMethodIDNoThrow(global::android.text.Spanned_.staticClass, "getSpans", "(IILjava/lang/Class;)[Ljava/lang/Object;");
			global::android.text.Spanned_._getSpanStart7863 = @__env.GetMethodIDNoThrow(global::android.text.Spanned_.staticClass, "getSpanStart", "(Ljava/lang/Object;)I");
			global::android.text.Spanned_._getSpanEnd7864 = @__env.GetMethodIDNoThrow(global::android.text.Spanned_.staticClass, "getSpanEnd", "(Ljava/lang/Object;)I");
			global::android.text.Spanned_._getSpanFlags7865 = @__env.GetMethodIDNoThrow(global::android.text.Spanned_.staticClass, "getSpanFlags", "(Ljava/lang/Object;)I");
			global::android.text.Spanned_._nextSpanTransition7866 = @__env.GetMethodIDNoThrow(global::android.text.Spanned_.staticClass, "nextSpanTransition", "(IILjava/lang/Class;)I");
			global::android.text.Spanned_._toString7867 = @__env.GetMethodIDNoThrow(global::android.text.Spanned_.staticClass, "toString", "()Ljava/lang/String;");
			global::android.text.Spanned_._length7868 = @__env.GetMethodIDNoThrow(global::android.text.Spanned_.staticClass, "length", "()I");
			global::android.text.Spanned_._charAt7869 = @__env.GetMethodIDNoThrow(global::android.text.Spanned_.staticClass, "charAt", "(I)C");
			global::android.text.Spanned_._subSequence7870 = @__env.GetMethodIDNoThrow(global::android.text.Spanned_.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
		}
	}
}
