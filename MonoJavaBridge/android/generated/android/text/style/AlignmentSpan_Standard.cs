namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AlignmentSpan_Standard : java.lang.Object, AlignmentSpan, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AlignmentSpan_Standard(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.AlignmentSpan_Standard.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.text.style.AlignmentSpan_Standard._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.AlignmentSpan_Standard.staticClass, "describeContents", "()I", ref global::android.text.style.AlignmentSpan_Standard._m1);
		}
		public new global::android.text.Layout.Alignment Alignment
		{
			get
			{
				return getAlignment();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::android.text.Layout.Alignment getAlignment()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.text.Layout.Alignment>(this, global::android.text.style.AlignmentSpan_Standard.staticClass, "getAlignment", "()Landroid/text/Layout$Alignment;", ref global::android.text.style.AlignmentSpan_Standard._m2) as android.text.Layout.Alignment;
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getSpanTypeId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.AlignmentSpan_Standard.staticClass, "getSpanTypeId", "()I", ref global::android.text.style.AlignmentSpan_Standard._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public AlignmentSpan_Standard(android.text.Layout.Alignment arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.AlignmentSpan_Standard._m4.native == global::System.IntPtr.Zero)
				global::android.text.style.AlignmentSpan_Standard._m4 = @__env.GetMethodIDNoThrow(global::android.text.style.AlignmentSpan_Standard.staticClass, "<init>", "(Landroid/text/Layout$Alignment;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.AlignmentSpan_Standard.staticClass, global::android.text.style.AlignmentSpan_Standard._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public AlignmentSpan_Standard(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.AlignmentSpan_Standard._m5.native == global::System.IntPtr.Zero)
				global::android.text.style.AlignmentSpan_Standard._m5 = @__env.GetMethodIDNoThrow(global::android.text.style.AlignmentSpan_Standard.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.AlignmentSpan_Standard.staticClass, global::android.text.style.AlignmentSpan_Standard._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AlignmentSpan_Standard()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.AlignmentSpan_Standard.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/AlignmentSpan$Standard"));
		}
		internal static void InitJNI()
		{
		}
	}
}
