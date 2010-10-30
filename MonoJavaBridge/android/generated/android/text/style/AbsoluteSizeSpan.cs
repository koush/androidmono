namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AbsoluteSizeSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbsoluteSizeSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int Size
		{
			get
			{
				return getSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSize13425;
		public virtual int getSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._getSize13425);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel13426;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._writeToParcel13426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents13427;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._describeContents13427);
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId13428;
		public virtual int getSpanTypeId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._getSpanTypeId13428);
		}
		internal static global::MonoJavaBridge.MethodId _updateDrawState13429;
		public override void updateDrawState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._updateDrawState13429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool Dip
		{
			get
			{
				return getDip();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDip13430;
		public virtual bool getDip()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._getDip13430);
		}
		internal static global::MonoJavaBridge.MethodId _updateMeasureState13431;
		public override void updateMeasureState(android.text.TextPaint arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._updateMeasureState13431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbsoluteSizeSpan13432;
		public AbsoluteSizeSpan(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._AbsoluteSizeSpan13432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsoluteSizeSpan13433;
		public AbsoluteSizeSpan(int arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._AbsoluteSizeSpan13433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AbsoluteSizeSpan13434;
		public AbsoluteSizeSpan(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.AbsoluteSizeSpan.staticClass, global::android.text.style.AbsoluteSizeSpan._AbsoluteSizeSpan13434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AbsoluteSizeSpan()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.AbsoluteSizeSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/AbsoluteSizeSpan"));
			global::android.text.style.AbsoluteSizeSpan._getSize13425 = @__env.GetMethodIDNoThrow(global::android.text.style.AbsoluteSizeSpan.staticClass, "getSize", "()I");
			global::android.text.style.AbsoluteSizeSpan._writeToParcel13426 = @__env.GetMethodIDNoThrow(global::android.text.style.AbsoluteSizeSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.text.style.AbsoluteSizeSpan._describeContents13427 = @__env.GetMethodIDNoThrow(global::android.text.style.AbsoluteSizeSpan.staticClass, "describeContents", "()I");
			global::android.text.style.AbsoluteSizeSpan._getSpanTypeId13428 = @__env.GetMethodIDNoThrow(global::android.text.style.AbsoluteSizeSpan.staticClass, "getSpanTypeId", "()I");
			global::android.text.style.AbsoluteSizeSpan._updateDrawState13429 = @__env.GetMethodIDNoThrow(global::android.text.style.AbsoluteSizeSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.AbsoluteSizeSpan._getDip13430 = @__env.GetMethodIDNoThrow(global::android.text.style.AbsoluteSizeSpan.staticClass, "getDip", "()Z");
			global::android.text.style.AbsoluteSizeSpan._updateMeasureState13431 = @__env.GetMethodIDNoThrow(global::android.text.style.AbsoluteSizeSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V");
			global::android.text.style.AbsoluteSizeSpan._AbsoluteSizeSpan13432 = @__env.GetMethodIDNoThrow(global::android.text.style.AbsoluteSizeSpan.staticClass, "<init>", "(I)V");
			global::android.text.style.AbsoluteSizeSpan._AbsoluteSizeSpan13433 = @__env.GetMethodIDNoThrow(global::android.text.style.AbsoluteSizeSpan.staticClass, "<init>", "(IZ)V");
			global::android.text.style.AbsoluteSizeSpan._AbsoluteSizeSpan13434 = @__env.GetMethodIDNoThrow(global::android.text.style.AbsoluteSizeSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
