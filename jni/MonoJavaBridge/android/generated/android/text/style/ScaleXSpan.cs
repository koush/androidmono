namespace android.text.style
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ScaleXSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{
		internal new static global::java.lang.Class staticClass;
		static ScaleXSpan()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.style.ScaleXSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.style.ScaleXSpan(@__env);
			}
		}
		protected ScaleXSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel8028;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.ScaleXSpan._writeToParcel8028, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.ScaleXSpan.staticClass, global::android.text.style.ScaleXSpan._writeToParcel8028, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents8029;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.ScaleXSpan._describeContents8029);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.ScaleXSpan.staticClass, global::android.text.style.ScaleXSpan._describeContents8029);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId8030;
		public virtual int getSpanTypeId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.ScaleXSpan._getSpanTypeId8030);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.ScaleXSpan.staticClass, global::android.text.style.ScaleXSpan._getSpanTypeId8030);
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateDrawState8031;
		public override void updateDrawState(android.text.TextPaint arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.ScaleXSpan._updateDrawState8031, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.ScaleXSpan.staticClass, global::android.text.style.ScaleXSpan._updateDrawState8031, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateMeasureState8032;
		public override void updateMeasureState(android.text.TextPaint arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.ScaleXSpan._updateMeasureState8032, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.ScaleXSpan.staticClass, global::android.text.style.ScaleXSpan._updateMeasureState8032, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getScaleX8033;
		public virtual float getScaleX() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.text.style.ScaleXSpan._getScaleX8033);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.text.style.ScaleXSpan.staticClass, global::android.text.style.ScaleXSpan._getScaleX8033);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ScaleXSpan8034;
		public ScaleXSpan(float arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.ScaleXSpan.staticClass, global::android.text.style.ScaleXSpan._ScaleXSpan8034, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ScaleXSpan8035;
		public ScaleXSpan(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.ScaleXSpan.staticClass, global::android.text.style.ScaleXSpan._ScaleXSpan8035, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.style.ScaleXSpan.staticClass = @__class;
			global::android.text.style.ScaleXSpan._writeToParcel8028 = @__env.GetMethodID(global::android.text.style.ScaleXSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.ScaleXSpan._describeContents8029 = @__env.GetMethodID(global::android.text.style.ScaleXSpan.staticClass, "describeContents", "()I");
			global::android.text.style.ScaleXSpan._getSpanTypeId8030 = @__env.GetMethodID(global::android.text.style.ScaleXSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.ScaleXSpan._updateDrawState8031 = @__env.GetMethodID(global::android.text.style.ScaleXSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.ScaleXSpan._updateMeasureState8032 = @__env.GetMethodID(global::android.text.style.ScaleXSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.ScaleXSpan._getScaleX8033 = @__env.GetMethodID(global::android.text.style.ScaleXSpan.staticClass, "getScaleX", "()F");
			global::android.text.style.ScaleXSpan._ScaleXSpan8034 = @__env.GetMethodID(global::android.text.style.ScaleXSpan.staticClass, "<init>", "(F)V");
			global::android.text.style.ScaleXSpan._ScaleXSpan8035 = @__env.GetMethodID(global::android.text.style.ScaleXSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
