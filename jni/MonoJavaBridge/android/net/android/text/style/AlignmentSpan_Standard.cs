namespace android.text.style 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AlignmentSpan_Standard : java.lang.Object, AlignmentSpan, ParcelableSpan
	{ 
		internal static global::java.lang.Class staticClass; 
		static AlignmentSpan_Standard() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.style.AlignmentSpan_Standard), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.style.AlignmentSpan_Standard(@__env); 
			} 
		} 
		protected AlignmentSpan_Standard(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel6917; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.AlignmentSpan_Standard)) 
				@__env.CallVoidMethod(this, _writeToParcel6917, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.AlignmentSpan_Standard.staticClass, _writeToParcel6917, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents6918; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.AlignmentSpan_Standard)) 
				return @__env.CallIntMethod(this, _describeContents6918); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.AlignmentSpan_Standard.staticClass, _describeContents6918); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAlignment6919; 
		public virtual android.text.Layout.Alignment getAlignment() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.AlignmentSpan_Standard)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout.Alignment>(@__env, @__env.CallObjectMethodPtr(this, _getAlignment6919)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout.Alignment>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.style.AlignmentSpan_Standard.staticClass, _getAlignment6919)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId6920; 
		public virtual int getSpanTypeId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.AlignmentSpan_Standard)) 
				return @__env.CallIntMethod(this, _getSpanTypeId6920); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.AlignmentSpan_Standard.staticClass, _getSpanTypeId6920); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AlignmentSpan_Standard6921; 
		public AlignmentSpan_Standard(android.text.Layout.Alignment arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.AlignmentSpan_Standard.staticClass, _AlignmentSpan_Standard6921, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AlignmentSpan_Standard6922; 
		public AlignmentSpan_Standard(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.AlignmentSpan_Standard.staticClass, _AlignmentSpan_Standard6922, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.style.AlignmentSpan_Standard.staticClass = @__class; 
			global::android.text.style.AlignmentSpan_Standard._writeToParcel6917 = @__env.GetMethodID(global::android.text.style.AlignmentSpan_Standard.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.text.style.AlignmentSpan_Standard._describeContents6918 = @__env.GetMethodID(global::android.text.style.AlignmentSpan_Standard.staticClass, "describeContents", "()I"); 
			global::android.text.style.AlignmentSpan_Standard._getAlignment6919 = @__env.GetMethodID(global::android.text.style.AlignmentSpan_Standard.staticClass, "getAlignment", "()Landroid/text/Layout$Alignment;"); 
			global::android.text.style.AlignmentSpan_Standard._getSpanTypeId6920 = @__env.GetMethodID(global::android.text.style.AlignmentSpan_Standard.staticClass, "getSpanTypeId", "()I"); 
			global::android.text.style.AlignmentSpan_Standard._AlignmentSpan_Standard6921 = @__env.GetMethodID(global::android.text.style.AlignmentSpan_Standard.staticClass, "<init>", "(Landroid/text/Layout$Alignment;)V"); 
			global::android.text.style.AlignmentSpan_Standard._AlignmentSpan_Standard6922 = @__env.GetMethodID(global::android.text.style.AlignmentSpan_Standard.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 
