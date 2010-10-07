namespace android.text.style
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class StyleSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{
		internal new static global::java.lang.Class staticClass;
		static StyleSpan()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.style.StyleSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.style.StyleSpan(@__env);
			}
		}
		protected StyleSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel8042;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.StyleSpan._writeToParcel8042, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.StyleSpan.staticClass, global::android.text.style.StyleSpan._writeToParcel8042, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents8043;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.StyleSpan._describeContents8043);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.StyleSpan.staticClass, global::android.text.style.StyleSpan._describeContents8043);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStyle8044;
		public virtual int getStyle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.StyleSpan._getStyle8044);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.StyleSpan.staticClass, global::android.text.style.StyleSpan._getStyle8044);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId8045;
		public virtual int getSpanTypeId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.StyleSpan._getSpanTypeId8045);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.StyleSpan.staticClass, global::android.text.style.StyleSpan._getSpanTypeId8045);
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateDrawState8046;
		public override void updateDrawState(android.text.TextPaint arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.StyleSpan._updateDrawState8046, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.StyleSpan.staticClass, global::android.text.style.StyleSpan._updateDrawState8046, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateMeasureState8047;
		public override void updateMeasureState(android.text.TextPaint arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.StyleSpan._updateMeasureState8047, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.StyleSpan.staticClass, global::android.text.style.StyleSpan._updateMeasureState8047, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _StyleSpan8048;
		public StyleSpan(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.StyleSpan.staticClass, global::android.text.style.StyleSpan._StyleSpan8048, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _StyleSpan8049;
		public StyleSpan(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.StyleSpan.staticClass, global::android.text.style.StyleSpan._StyleSpan8049, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.style.StyleSpan.staticClass = @__class;
			global::android.text.style.StyleSpan._writeToParcel8042 = @__env.GetMethodID(global::android.text.style.StyleSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.StyleSpan._describeContents8043 = @__env.GetMethodID(global::android.text.style.StyleSpan.staticClass, "describeContents", "()I");
			global::android.text.style.StyleSpan._getStyle8044 = @__env.GetMethodID(global::android.text.style.StyleSpan.staticClass, "getStyle", "()I");
			global::android.text.style.StyleSpan._getSpanTypeId8045 = @__env.GetMethodID(global::android.text.style.StyleSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.StyleSpan._updateDrawState8046 = @__env.GetMethodID(global::android.text.style.StyleSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.StyleSpan._updateMeasureState8047 = @__env.GetMethodID(global::android.text.style.StyleSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.StyleSpan._StyleSpan8048 = @__env.GetMethodID(global::android.text.style.StyleSpan.staticClass, "<init>", "(I)V");
			global::android.text.style.StyleSpan._StyleSpan8049 = @__env.GetMethodID(global::android.text.style.StyleSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
