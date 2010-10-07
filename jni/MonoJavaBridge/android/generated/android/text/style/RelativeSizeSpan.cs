namespace android.text.style
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class RelativeSizeSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{
		internal new static global::java.lang.Class staticClass;
		static RelativeSizeSpan()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.style.RelativeSizeSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.style.RelativeSizeSpan(@__env);
			}
		}
		protected RelativeSizeSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel8015;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.RelativeSizeSpan._writeToParcel8015, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.RelativeSizeSpan.staticClass, global::android.text.style.RelativeSizeSpan._writeToParcel8015, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents8016;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.RelativeSizeSpan._describeContents8016);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.RelativeSizeSpan.staticClass, global::android.text.style.RelativeSizeSpan._describeContents8016);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId8017;
		public virtual int getSpanTypeId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.RelativeSizeSpan._getSpanTypeId8017);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.RelativeSizeSpan.staticClass, global::android.text.style.RelativeSizeSpan._getSpanTypeId8017);
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateDrawState8018;
		public override void updateDrawState(android.text.TextPaint arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.RelativeSizeSpan._updateDrawState8018, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.RelativeSizeSpan.staticClass, global::android.text.style.RelativeSizeSpan._updateDrawState8018, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateMeasureState8019;
		public override void updateMeasureState(android.text.TextPaint arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.RelativeSizeSpan._updateMeasureState8019, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.RelativeSizeSpan.staticClass, global::android.text.style.RelativeSizeSpan._updateMeasureState8019, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSizeChange8020;
		public virtual float getSizeChange() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.text.style.RelativeSizeSpan._getSizeChange8020);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.text.style.RelativeSizeSpan.staticClass, global::android.text.style.RelativeSizeSpan._getSizeChange8020);
		}
		internal static global::net.sf.jni4net.jni.MethodId _RelativeSizeSpan8021;
		public RelativeSizeSpan(float arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.RelativeSizeSpan.staticClass, global::android.text.style.RelativeSizeSpan._RelativeSizeSpan8021, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _RelativeSizeSpan8022;
		public RelativeSizeSpan(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.RelativeSizeSpan.staticClass, global::android.text.style.RelativeSizeSpan._RelativeSizeSpan8022, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.style.RelativeSizeSpan.staticClass = @__class;
			global::android.text.style.RelativeSizeSpan._writeToParcel8015 = @__env.GetMethodID(global::android.text.style.RelativeSizeSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.RelativeSizeSpan._describeContents8016 = @__env.GetMethodID(global::android.text.style.RelativeSizeSpan.staticClass, "describeContents", "()I");
			global::android.text.style.RelativeSizeSpan._getSpanTypeId8017 = @__env.GetMethodID(global::android.text.style.RelativeSizeSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.RelativeSizeSpan._updateDrawState8018 = @__env.GetMethodID(global::android.text.style.RelativeSizeSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.RelativeSizeSpan._updateMeasureState8019 = @__env.GetMethodID(global::android.text.style.RelativeSizeSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.RelativeSizeSpan._getSizeChange8020 = @__env.GetMethodID(global::android.text.style.RelativeSizeSpan.staticClass, "getSizeChange", "()F");
			global::android.text.style.RelativeSizeSpan._RelativeSizeSpan8021 = @__env.GetMethodID(global::android.text.style.RelativeSizeSpan.staticClass, "<init>", "(F)V");
			global::android.text.style.RelativeSizeSpan._RelativeSizeSpan8022 = @__env.GetMethodID(global::android.text.style.RelativeSizeSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
