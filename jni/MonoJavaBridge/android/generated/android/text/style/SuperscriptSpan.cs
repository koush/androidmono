namespace android.text.style
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SuperscriptSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{
		internal new static global::java.lang.Class staticClass;
		static SuperscriptSpan()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.style.SuperscriptSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.style.SuperscriptSpan(@__env);
			}
		}
		protected SuperscriptSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel8057;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.SuperscriptSpan._writeToParcel8057, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.SuperscriptSpan.staticClass, global::android.text.style.SuperscriptSpan._writeToParcel8057, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents8058;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.SuperscriptSpan._describeContents8058);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.SuperscriptSpan.staticClass, global::android.text.style.SuperscriptSpan._describeContents8058);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId8059;
		public virtual int getSpanTypeId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.SuperscriptSpan._getSpanTypeId8059);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.SuperscriptSpan.staticClass, global::android.text.style.SuperscriptSpan._getSpanTypeId8059);
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateDrawState8060;
		public override void updateDrawState(android.text.TextPaint arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.SuperscriptSpan._updateDrawState8060, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.SuperscriptSpan.staticClass, global::android.text.style.SuperscriptSpan._updateDrawState8060, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateMeasureState8061;
		public override void updateMeasureState(android.text.TextPaint arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.SuperscriptSpan._updateMeasureState8061, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.SuperscriptSpan.staticClass, global::android.text.style.SuperscriptSpan._updateMeasureState8061, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SuperscriptSpan8062;
		public SuperscriptSpan()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.SuperscriptSpan.staticClass, global::android.text.style.SuperscriptSpan._SuperscriptSpan8062, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _SuperscriptSpan8063;
		public SuperscriptSpan(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.SuperscriptSpan.staticClass, global::android.text.style.SuperscriptSpan._SuperscriptSpan8063, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.style.SuperscriptSpan.staticClass = @__class;
			global::android.text.style.SuperscriptSpan._writeToParcel8057 = @__env.GetMethodID(global::android.text.style.SuperscriptSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.SuperscriptSpan._describeContents8058 = @__env.GetMethodID(global::android.text.style.SuperscriptSpan.staticClass, "describeContents", "()I");
			global::android.text.style.SuperscriptSpan._getSpanTypeId8059 = @__env.GetMethodID(global::android.text.style.SuperscriptSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.SuperscriptSpan._updateDrawState8060 = @__env.GetMethodID(global::android.text.style.SuperscriptSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.SuperscriptSpan._updateMeasureState8061 = @__env.GetMethodID(global::android.text.style.SuperscriptSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.SuperscriptSpan._SuperscriptSpan8062 = @__env.GetMethodID(global::android.text.style.SuperscriptSpan.staticClass, "<init>", "()V");
			global::android.text.style.SuperscriptSpan._SuperscriptSpan8063 = @__env.GetMethodID(global::android.text.style.SuperscriptSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
