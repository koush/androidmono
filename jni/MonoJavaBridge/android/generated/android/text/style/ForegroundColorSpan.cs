namespace android.text.style
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ForegroundColorSpan : android.text.style.CharacterStyle, UpdateAppearance, ParcelableSpan
	{
		internal new static global::java.lang.Class staticClass;
		static ForegroundColorSpan()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.style.ForegroundColorSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.style.ForegroundColorSpan(@__env);
			}
		}
		protected ForegroundColorSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel7328;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.ForegroundColorSpan._writeToParcel7328, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.ForegroundColorSpan.staticClass, global::android.text.style.ForegroundColorSpan._writeToParcel7328, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents7329;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.ForegroundColorSpan._describeContents7329);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.ForegroundColorSpan.staticClass, global::android.text.style.ForegroundColorSpan._describeContents7329);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId7330;
		public virtual int getSpanTypeId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.ForegroundColorSpan._getSpanTypeId7330);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.ForegroundColorSpan.staticClass, global::android.text.style.ForegroundColorSpan._getSpanTypeId7330);
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateDrawState7331;
		public override void updateDrawState(android.text.TextPaint arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.ForegroundColorSpan._updateDrawState7331, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.ForegroundColorSpan.staticClass, global::android.text.style.ForegroundColorSpan._updateDrawState7331, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getForegroundColor7332;
		public virtual int getForegroundColor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.ForegroundColorSpan._getForegroundColor7332);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.ForegroundColorSpan.staticClass, global::android.text.style.ForegroundColorSpan._getForegroundColor7332);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ForegroundColorSpan7333;
		public ForegroundColorSpan(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.ForegroundColorSpan.staticClass, global::android.text.style.ForegroundColorSpan._ForegroundColorSpan7333, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ForegroundColorSpan7334;
		public ForegroundColorSpan(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.ForegroundColorSpan.staticClass, global::android.text.style.ForegroundColorSpan._ForegroundColorSpan7334, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.style.ForegroundColorSpan.staticClass = @__class;
			global::android.text.style.ForegroundColorSpan._writeToParcel7328 = @__env.GetMethodID(global::android.text.style.ForegroundColorSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.ForegroundColorSpan._describeContents7329 = @__env.GetMethodID(global::android.text.style.ForegroundColorSpan.staticClass, "describeContents", "()I");
			global::android.text.style.ForegroundColorSpan._getSpanTypeId7330 = @__env.GetMethodID(global::android.text.style.ForegroundColorSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.ForegroundColorSpan._updateDrawState7331 = @__env.GetMethodID(global::android.text.style.ForegroundColorSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.ForegroundColorSpan._getForegroundColor7332 = @__env.GetMethodID(global::android.text.style.ForegroundColorSpan.staticClass, "getForegroundColor", "()I");
			global::android.text.style.ForegroundColorSpan._ForegroundColorSpan7333 = @__env.GetMethodID(global::android.text.style.ForegroundColorSpan.staticClass, "<init>", "(I)V");
			global::android.text.style.ForegroundColorSpan._ForegroundColorSpan7334 = @__env.GetMethodID(global::android.text.style.ForegroundColorSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
