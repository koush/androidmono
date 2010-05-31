namespace android.text.style
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class UnderlineSpan : android.text.style.CharacterStyle, UpdateAppearance, ParcelableSpan
	{
		internal new static global::java.lang.Class staticClass;
		static UnderlineSpan()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.style.UnderlineSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.style.UnderlineSpan(@__env);
			}
		}
		protected UnderlineSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel7467;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.UnderlineSpan._writeToParcel7467, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.UnderlineSpan.staticClass, global::android.text.style.UnderlineSpan._writeToParcel7467, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents7468;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.UnderlineSpan._describeContents7468);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.UnderlineSpan.staticClass, global::android.text.style.UnderlineSpan._describeContents7468);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId7469;
		public virtual int getSpanTypeId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.UnderlineSpan._getSpanTypeId7469);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.UnderlineSpan.staticClass, global::android.text.style.UnderlineSpan._getSpanTypeId7469);
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateDrawState7470;
		public override void updateDrawState(android.text.TextPaint arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.UnderlineSpan._updateDrawState7470, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.UnderlineSpan.staticClass, global::android.text.style.UnderlineSpan._updateDrawState7470, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _UnderlineSpan7471;
		public UnderlineSpan()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.UnderlineSpan.staticClass, global::android.text.style.UnderlineSpan._UnderlineSpan7471, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _UnderlineSpan7472;
		public UnderlineSpan(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.UnderlineSpan.staticClass, global::android.text.style.UnderlineSpan._UnderlineSpan7472, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.style.UnderlineSpan.staticClass = @__class;
			global::android.text.style.UnderlineSpan._writeToParcel7467 = @__env.GetMethodID(global::android.text.style.UnderlineSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.UnderlineSpan._describeContents7468 = @__env.GetMethodID(global::android.text.style.UnderlineSpan.staticClass, "describeContents", "()I");
			global::android.text.style.UnderlineSpan._getSpanTypeId7469 = @__env.GetMethodID(global::android.text.style.UnderlineSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.UnderlineSpan._updateDrawState7470 = @__env.GetMethodID(global::android.text.style.UnderlineSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.UnderlineSpan._UnderlineSpan7471 = @__env.GetMethodID(global::android.text.style.UnderlineSpan.staticClass, "<init>", "()V");
			global::android.text.style.UnderlineSpan._UnderlineSpan7472 = @__env.GetMethodID(global::android.text.style.UnderlineSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
