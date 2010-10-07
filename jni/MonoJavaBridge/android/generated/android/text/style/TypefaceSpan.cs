namespace android.text.style
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class TypefaceSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{
		internal new static global::java.lang.Class staticClass;
		static TypefaceSpan()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.style.TypefaceSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.style.TypefaceSpan(@__env);
			}
		}
		protected TypefaceSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel8081;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.TypefaceSpan._writeToParcel8081, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.TypefaceSpan.staticClass, global::android.text.style.TypefaceSpan._writeToParcel8081, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents8082;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.TypefaceSpan._describeContents8082);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.TypefaceSpan.staticClass, global::android.text.style.TypefaceSpan._describeContents8082);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId8083;
		public virtual int getSpanTypeId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.TypefaceSpan._getSpanTypeId8083);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.TypefaceSpan.staticClass, global::android.text.style.TypefaceSpan._getSpanTypeId8083);
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateDrawState8084;
		public override void updateDrawState(android.text.TextPaint arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.TypefaceSpan._updateDrawState8084, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.TypefaceSpan.staticClass, global::android.text.style.TypefaceSpan._updateDrawState8084, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateMeasureState8085;
		public override void updateMeasureState(android.text.TextPaint arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.TypefaceSpan._updateMeasureState8085, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.TypefaceSpan.staticClass, global::android.text.style.TypefaceSpan._updateMeasureState8085, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFamily8086;
		public virtual global::java.lang.String getFamily() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.text.style.TypefaceSpan._getFamily8086));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.text.style.TypefaceSpan.staticClass, global::android.text.style.TypefaceSpan._getFamily8086));
		}
		internal static global::net.sf.jni4net.jni.MethodId _TypefaceSpan8087;
		public TypefaceSpan(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.TypefaceSpan.staticClass, global::android.text.style.TypefaceSpan._TypefaceSpan8087, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _TypefaceSpan8088;
		public TypefaceSpan(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.TypefaceSpan.staticClass, global::android.text.style.TypefaceSpan._TypefaceSpan8088, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.style.TypefaceSpan.staticClass = @__class;
			global::android.text.style.TypefaceSpan._writeToParcel8081 = @__env.GetMethodID(global::android.text.style.TypefaceSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.TypefaceSpan._describeContents8082 = @__env.GetMethodID(global::android.text.style.TypefaceSpan.staticClass, "describeContents", "()I");
			global::android.text.style.TypefaceSpan._getSpanTypeId8083 = @__env.GetMethodID(global::android.text.style.TypefaceSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.TypefaceSpan._updateDrawState8084 = @__env.GetMethodID(global::android.text.style.TypefaceSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.TypefaceSpan._updateMeasureState8085 = @__env.GetMethodID(global::android.text.style.TypefaceSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.TypefaceSpan._getFamily8086 = @__env.GetMethodID(global::android.text.style.TypefaceSpan.staticClass, "getFamily", "()Ljava/lang/String;");
			global::android.text.style.TypefaceSpan._TypefaceSpan8087 = @__env.GetMethodID(global::android.text.style.TypefaceSpan.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.text.style.TypefaceSpan._TypefaceSpan8088 = @__env.GetMethodID(global::android.text.style.TypefaceSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
