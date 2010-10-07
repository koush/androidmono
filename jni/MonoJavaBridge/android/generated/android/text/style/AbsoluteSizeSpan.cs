namespace android.text.style
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class AbsoluteSizeSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{
		internal new static global::java.lang.Class staticClass;
		static AbsoluteSizeSpan()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.style.AbsoluteSizeSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.text.style.AbsoluteSizeSpan(@__env);
			}
		}
		protected AbsoluteSizeSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSize7903;
		public virtual int getSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.AbsoluteSizeSpan._getSize7903);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._getSize7903);
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel7904;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.AbsoluteSizeSpan._writeToParcel7904, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._writeToParcel7904, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents7905;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.AbsoluteSizeSpan._describeContents7905);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._describeContents7905);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId7906;
		public virtual int getSpanTypeId() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.text.style.AbsoluteSizeSpan._getSpanTypeId7906);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._getSpanTypeId7906);
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateDrawState7907;
		public override void updateDrawState(android.text.TextPaint arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.AbsoluteSizeSpan._updateDrawState7907, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._updateDrawState7907, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDip7908;
		public virtual bool getDip() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.text.style.AbsoluteSizeSpan._getDip7908);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._getDip7908);
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateMeasureState7909;
		public override void updateMeasureState(android.text.TextPaint arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.text.style.AbsoluteSizeSpan._updateMeasureState7909, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._updateMeasureState7909, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AbsoluteSizeSpan7910;
		public AbsoluteSizeSpan(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._AbsoluteSizeSpan7910, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AbsoluteSizeSpan7911;
		public AbsoluteSizeSpan(int arg0, bool arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._AbsoluteSizeSpan7911, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AbsoluteSizeSpan7912;
		public AbsoluteSizeSpan(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._AbsoluteSizeSpan7912, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.text.style.AbsoluteSizeSpan.staticClass = @__class;
			global::android.text.style.AbsoluteSizeSpan._getSize7903 = @__env.GetMethodID(global::android.text.style.AbsoluteSizeSpan.staticClass, "getSize", "()I");
			global::android.text.style.AbsoluteSizeSpan._writeToParcel7904 = @__env.GetMethodID(global::android.text.style.AbsoluteSizeSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.AbsoluteSizeSpan._describeContents7905 = @__env.GetMethodID(global::android.text.style.AbsoluteSizeSpan.staticClass, "describeContents", "()I");
			global::android.text.style.AbsoluteSizeSpan._getSpanTypeId7906 = @__env.GetMethodID(global::android.text.style.AbsoluteSizeSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.AbsoluteSizeSpan._updateDrawState7907 = @__env.GetMethodID(global::android.text.style.AbsoluteSizeSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.AbsoluteSizeSpan._getDip7908 = @__env.GetMethodID(global::android.text.style.AbsoluteSizeSpan.staticClass, "getDip", "()Z");
			global::android.text.style.AbsoluteSizeSpan._updateMeasureState7909 = @__env.GetMethodID(global::android.text.style.AbsoluteSizeSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.AbsoluteSizeSpan._AbsoluteSizeSpan7910 = @__env.GetMethodID(global::android.text.style.AbsoluteSizeSpan.staticClass, "<init>", "(I)V");
			global::android.text.style.AbsoluteSizeSpan._AbsoluteSizeSpan7911 = @__env.GetMethodID(global::android.text.style.AbsoluteSizeSpan.staticClass, "<init>", "(IZ)V");
			global::android.text.style.AbsoluteSizeSpan._AbsoluteSizeSpan7912 = @__env.GetMethodID(global::android.text.style.AbsoluteSizeSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
