namespace android.text.style
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class StrikethroughSpan : android.text.style.CharacterStyle, UpdateAppearance, ParcelableSpan
	{
		internal new static global::java.lang.Class staticClass;
		static StrikethroughSpan()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.style.StrikethroughSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.style.StrikethroughSpan(@__env);
			}
		}
		protected StrikethroughSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel8036;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.StrikethroughSpan._writeToParcel8036, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.StrikethroughSpan.staticClass, global::android.text.style.StrikethroughSpan._writeToParcel8036, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents8037;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.StrikethroughSpan._describeContents8037);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.StrikethroughSpan.staticClass, global::android.text.style.StrikethroughSpan._describeContents8037);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId8038;
		public virtual int getSpanTypeId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.StrikethroughSpan._getSpanTypeId8038);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.StrikethroughSpan.staticClass, global::android.text.style.StrikethroughSpan._getSpanTypeId8038);
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateDrawState8039;
		public override void updateDrawState(android.text.TextPaint arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.StrikethroughSpan._updateDrawState8039, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.StrikethroughSpan.staticClass, global::android.text.style.StrikethroughSpan._updateDrawState8039, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _StrikethroughSpan8040;
		public StrikethroughSpan()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.StrikethroughSpan.staticClass, global::android.text.style.StrikethroughSpan._StrikethroughSpan8040, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _StrikethroughSpan8041;
		public StrikethroughSpan(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.StrikethroughSpan.staticClass, global::android.text.style.StrikethroughSpan._StrikethroughSpan8041, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.style.StrikethroughSpan.staticClass = @__class;
			global::android.text.style.StrikethroughSpan._writeToParcel8036 = @__env.GetMethodID(global::android.text.style.StrikethroughSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.StrikethroughSpan._describeContents8037 = @__env.GetMethodID(global::android.text.style.StrikethroughSpan.staticClass, "describeContents", "()I");
			global::android.text.style.StrikethroughSpan._getSpanTypeId8038 = @__env.GetMethodID(global::android.text.style.StrikethroughSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.StrikethroughSpan._updateDrawState8039 = @__env.GetMethodID(global::android.text.style.StrikethroughSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.StrikethroughSpan._StrikethroughSpan8040 = @__env.GetMethodID(global::android.text.style.StrikethroughSpan.staticClass, "<init>", "()V");
			global::android.text.style.StrikethroughSpan._StrikethroughSpan8041 = @__env.GetMethodID(global::android.text.style.StrikethroughSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
