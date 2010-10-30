namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AlignmentSpan_Standard : java.lang.Object, AlignmentSpan, ParcelableSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AlignmentSpan_Standard(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel13435;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.AlignmentSpan_Standard._writeToParcel13435.native == global::System.IntPtr.Zero)
				global::android.text.style.AlignmentSpan_Standard._writeToParcel13435 = @__env.GetMethodIDNoThrow(global::android.text.style.AlignmentSpan_Standard.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.AlignmentSpan_Standard.staticClass, global::android.text.style.AlignmentSpan_Standard._writeToParcel13435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents13436;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.AlignmentSpan_Standard._describeContents13436.native == global::System.IntPtr.Zero)
				global::android.text.style.AlignmentSpan_Standard._describeContents13436 = @__env.GetMethodIDNoThrow(global::android.text.style.AlignmentSpan_Standard.staticClass, "describeContents", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.AlignmentSpan_Standard.staticClass, global::android.text.style.AlignmentSpan_Standard._describeContents13436);
		}
		public new global::android.text.Layout.Alignment Alignment
		{
			get
			{
				return getAlignment();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlignment13437;
		public virtual global::android.text.Layout.Alignment getAlignment()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.AlignmentSpan_Standard._getAlignment13437.native == global::System.IntPtr.Zero)
				global::android.text.style.AlignmentSpan_Standard._getAlignment13437 = @__env.GetMethodIDNoThrow(global::android.text.style.AlignmentSpan_Standard.staticClass, "getAlignment", "()Landroid/text/Layout$Alignment;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.text.Layout.Alignment>(this, global::android.text.style.AlignmentSpan_Standard.staticClass, global::android.text.style.AlignmentSpan_Standard._getAlignment13437) as android.text.Layout.Alignment;
		}
		public new int SpanTypeId
		{
			get
			{
				return getSpanTypeId();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSpanTypeId13438;
		public virtual int getSpanTypeId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.AlignmentSpan_Standard._getSpanTypeId13438.native == global::System.IntPtr.Zero)
				global::android.text.style.AlignmentSpan_Standard._getSpanTypeId13438 = @__env.GetMethodIDNoThrow(global::android.text.style.AlignmentSpan_Standard.staticClass, "getSpanTypeId", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.AlignmentSpan_Standard.staticClass, global::android.text.style.AlignmentSpan_Standard._getSpanTypeId13438);
		}
		internal static global::MonoJavaBridge.MethodId _AlignmentSpan_Standard13439;
		public AlignmentSpan_Standard(android.text.Layout.Alignment arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.AlignmentSpan_Standard._AlignmentSpan_Standard13439.native == global::System.IntPtr.Zero)
				global::android.text.style.AlignmentSpan_Standard._AlignmentSpan_Standard13439 = @__env.GetMethodIDNoThrow(global::android.text.style.AlignmentSpan_Standard.staticClass, "<init>", "(Landroid/text/Layout$Alignment;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.AlignmentSpan_Standard.staticClass, global::android.text.style.AlignmentSpan_Standard._AlignmentSpan_Standard13439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AlignmentSpan_Standard13440;
		public AlignmentSpan_Standard(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.AlignmentSpan_Standard._AlignmentSpan_Standard13440.native == global::System.IntPtr.Zero)
				global::android.text.style.AlignmentSpan_Standard._AlignmentSpan_Standard13440 = @__env.GetMethodIDNoThrow(global::android.text.style.AlignmentSpan_Standard.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.AlignmentSpan_Standard.staticClass, global::android.text.style.AlignmentSpan_Standard._AlignmentSpan_Standard13440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
