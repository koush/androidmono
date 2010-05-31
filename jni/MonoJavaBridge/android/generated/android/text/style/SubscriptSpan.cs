namespace android.text.style
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SubscriptSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{
		internal new static global::java.lang.Class staticClass;
		static SubscriptSpan()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.style.SubscriptSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.style.SubscriptSpan(@__env);
			}
		}
		protected SubscriptSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel7421;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.SubscriptSpan._writeToParcel7421, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.SubscriptSpan.staticClass, global::android.text.style.SubscriptSpan._writeToParcel7421, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents7422;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.SubscriptSpan._describeContents7422);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.SubscriptSpan.staticClass, global::android.text.style.SubscriptSpan._describeContents7422);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId7423;
		public virtual int getSpanTypeId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.SubscriptSpan._getSpanTypeId7423);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.SubscriptSpan.staticClass, global::android.text.style.SubscriptSpan._getSpanTypeId7423);
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateDrawState7424;
		public override void updateDrawState(android.text.TextPaint arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.SubscriptSpan._updateDrawState7424, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.SubscriptSpan.staticClass, global::android.text.style.SubscriptSpan._updateDrawState7424, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateMeasureState7425;
		public override void updateMeasureState(android.text.TextPaint arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.SubscriptSpan._updateMeasureState7425, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.SubscriptSpan.staticClass, global::android.text.style.SubscriptSpan._updateMeasureState7425, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SubscriptSpan7426;
		public SubscriptSpan()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.SubscriptSpan.staticClass, global::android.text.style.SubscriptSpan._SubscriptSpan7426, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _SubscriptSpan7427;
		public SubscriptSpan(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.SubscriptSpan.staticClass, global::android.text.style.SubscriptSpan._SubscriptSpan7427, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.style.SubscriptSpan.staticClass = @__class;
			global::android.text.style.SubscriptSpan._writeToParcel7421 = @__env.GetMethodID(global::android.text.style.SubscriptSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.SubscriptSpan._describeContents7422 = @__env.GetMethodID(global::android.text.style.SubscriptSpan.staticClass, "describeContents", "()I");
			global::android.text.style.SubscriptSpan._getSpanTypeId7423 = @__env.GetMethodID(global::android.text.style.SubscriptSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.SubscriptSpan._updateDrawState7424 = @__env.GetMethodID(global::android.text.style.SubscriptSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.SubscriptSpan._updateMeasureState7425 = @__env.GetMethodID(global::android.text.style.SubscriptSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.SubscriptSpan._SubscriptSpan7426 = @__env.GetMethodID(global::android.text.style.SubscriptSpan.staticClass, "<init>", "()V");
			global::android.text.style.SubscriptSpan._SubscriptSpan7427 = @__env.GetMethodID(global::android.text.style.SubscriptSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
