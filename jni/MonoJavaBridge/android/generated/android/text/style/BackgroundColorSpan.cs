namespace android.text.style
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class BackgroundColorSpan : android.text.style.CharacterStyle, UpdateAppearance, ParcelableSpan
	{
		internal new static global::java.lang.Class staticClass;
		static BackgroundColorSpan()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.style.BackgroundColorSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.style.BackgroundColorSpan(@__env);
			}
		}
		protected BackgroundColorSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel7920;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.BackgroundColorSpan._writeToParcel7920, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.BackgroundColorSpan.staticClass, global::android.text.style.BackgroundColorSpan._writeToParcel7920, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents7921;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.BackgroundColorSpan._describeContents7921);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.BackgroundColorSpan.staticClass, global::android.text.style.BackgroundColorSpan._describeContents7921);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId7922;
		public virtual int getSpanTypeId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.BackgroundColorSpan._getSpanTypeId7922);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.BackgroundColorSpan.staticClass, global::android.text.style.BackgroundColorSpan._getSpanTypeId7922);
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateDrawState7923;
		public override void updateDrawState(android.text.TextPaint arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.BackgroundColorSpan._updateDrawState7923, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.BackgroundColorSpan.staticClass, global::android.text.style.BackgroundColorSpan._updateDrawState7923, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBackgroundColor7924;
		public virtual int getBackgroundColor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.BackgroundColorSpan._getBackgroundColor7924);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.BackgroundColorSpan.staticClass, global::android.text.style.BackgroundColorSpan._getBackgroundColor7924);
		}
		internal static global::net.sf.jni4net.jni.MethodId _BackgroundColorSpan7925;
		public BackgroundColorSpan(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.BackgroundColorSpan.staticClass, global::android.text.style.BackgroundColorSpan._BackgroundColorSpan7925, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _BackgroundColorSpan7926;
		public BackgroundColorSpan(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.BackgroundColorSpan.staticClass, global::android.text.style.BackgroundColorSpan._BackgroundColorSpan7926, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.style.BackgroundColorSpan.staticClass = @__class;
			global::android.text.style.BackgroundColorSpan._writeToParcel7920 = @__env.GetMethodID(global::android.text.style.BackgroundColorSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.BackgroundColorSpan._describeContents7921 = @__env.GetMethodID(global::android.text.style.BackgroundColorSpan.staticClass, "describeContents", "()I");
			global::android.text.style.BackgroundColorSpan._getSpanTypeId7922 = @__env.GetMethodID(global::android.text.style.BackgroundColorSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.BackgroundColorSpan._updateDrawState7923 = @__env.GetMethodID(global::android.text.style.BackgroundColorSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.BackgroundColorSpan._getBackgroundColor7924 = @__env.GetMethodID(global::android.text.style.BackgroundColorSpan.staticClass, "getBackgroundColor", "()I");
			global::android.text.style.BackgroundColorSpan._BackgroundColorSpan7925 = @__env.GetMethodID(global::android.text.style.BackgroundColorSpan.staticClass, "<init>", "(I)V");
			global::android.text.style.BackgroundColorSpan._BackgroundColorSpan7926 = @__env.GetMethodID(global::android.text.style.BackgroundColorSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
