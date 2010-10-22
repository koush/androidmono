namespace android.text
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.Spannable_))]
	public partial interface Spannable : Spanned
	{
		void setSpan(java.lang.Object arg0, int arg1, int arg2, int arg3);
		void removeSpan(java.lang.Object arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.Spannable))]
	public sealed partial class Spannable_ : java.lang.Object, Spannable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Spannable_()
		{
			InitJNI();
		}
		internal Spannable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setSpan12872;
		 void android.text.Spannable.setSpan(java.lang.Object arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Spannable_._setSpan12872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Spannable_.staticClass, global::android.text.Spannable_._setSpan12872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _removeSpan12873;
		 void android.text.Spannable.removeSpan(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.Spannable_._removeSpan12873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Spannable_.staticClass, global::android.text.Spannable_._removeSpan12873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpans12874;
		 global::java.lang.Object[] android.text.Spanned.getSpans(int arg0, int arg1, java.lang.Class arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Spannable_._getSpans12874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Spannable_.staticClass, global::android.text.Spannable_._getSpans12874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _getSpanStart12875;
		 int android.text.Spanned.getSpanStart(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Spannable_._getSpanStart12875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Spannable_.staticClass, global::android.text.Spannable_._getSpanStart12875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpanEnd12876;
		 int android.text.Spanned.getSpanEnd(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Spannable_._getSpanEnd12876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Spannable_.staticClass, global::android.text.Spannable_._getSpanEnd12876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpanFlags12877;
		 int android.text.Spanned.getSpanFlags(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Spannable_._getSpanFlags12877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Spannable_.staticClass, global::android.text.Spannable_._getSpanFlags12877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextSpanTransition12878;
		 int android.text.Spanned.nextSpanTransition(int arg0, int arg1, java.lang.Class arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Spannable_._nextSpanTransition12878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Spannable_.staticClass, global::android.text.Spannable_._nextSpanTransition12878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _toString12879;
		 global::java.lang.String java.lang.CharSequence.toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Spannable_._toString12879)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Spannable_.staticClass, global::android.text.Spannable_._toString12879)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length12880;
		 int java.lang.CharSequence.length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.Spannable_._length12880);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.Spannable_.staticClass, global::android.text.Spannable_._length12880);
		}
		internal static global::MonoJavaBridge.MethodId _charAt12881;
		 char java.lang.CharSequence.charAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.text.Spannable_._charAt12881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.text.Spannable_.staticClass, global::android.text.Spannable_._charAt12881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _subSequence12882;
		 global::java.lang.CharSequence java.lang.CharSequence.subSequence(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Spannable_._subSequence12882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Spannable_.staticClass, global::android.text.Spannable_._subSequence12882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.Spannable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Spannable"));
			global::android.text.Spannable_._setSpan12872 = @__env.GetMethodIDNoThrow(global::android.text.Spannable_.staticClass, "setSpan", "(Ljava/lang/Object;III)V");
			global::android.text.Spannable_._removeSpan12873 = @__env.GetMethodIDNoThrow(global::android.text.Spannable_.staticClass, "removeSpan", "(Ljava/lang/Object;)V");
			global::android.text.Spannable_._getSpans12874 = @__env.GetMethodIDNoThrow(global::android.text.Spannable_.staticClass, "getSpans", "(IILjava/lang/Class;)[Ljava/lang/Object;");
			global::android.text.Spannable_._getSpanStart12875 = @__env.GetMethodIDNoThrow(global::android.text.Spannable_.staticClass, "getSpanStart", "(Ljava/lang/Object;)I");
			global::android.text.Spannable_._getSpanEnd12876 = @__env.GetMethodIDNoThrow(global::android.text.Spannable_.staticClass, "getSpanEnd", "(Ljava/lang/Object;)I");
			global::android.text.Spannable_._getSpanFlags12877 = @__env.GetMethodIDNoThrow(global::android.text.Spannable_.staticClass, "getSpanFlags", "(Ljava/lang/Object;)I");
			global::android.text.Spannable_._nextSpanTransition12878 = @__env.GetMethodIDNoThrow(global::android.text.Spannable_.staticClass, "nextSpanTransition", "(IILjava/lang/Class;)I");
			global::android.text.Spannable_._toString12879 = @__env.GetMethodIDNoThrow(global::android.text.Spannable_.staticClass, "toString", "()Ljava/lang/String;");
			global::android.text.Spannable_._length12880 = @__env.GetMethodIDNoThrow(global::android.text.Spannable_.staticClass, "length", "()I");
			global::android.text.Spannable_._charAt12881 = @__env.GetMethodIDNoThrow(global::android.text.Spannable_.staticClass, "charAt", "(I)C");
			global::android.text.Spannable_._subSequence12882 = @__env.GetMethodIDNoThrow(global::android.text.Spannable_.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
		}
	}
}
