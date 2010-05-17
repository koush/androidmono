namespace android.text.style 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ForegroundColorSpan : android.text.style.CharacterStyle, UpdateAppearance, ParcelableSpan
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ForegroundColorSpan() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.style.ForegroundColorSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.style.ForegroundColorSpan(@__env); 
			} 
		} 
		protected ForegroundColorSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel6957; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.ForegroundColorSpan)) 
				@__env.CallVoidMethod(this, _writeToParcel6957, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.ForegroundColorSpan.staticClass, _writeToParcel6957, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents6958; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.ForegroundColorSpan)) 
				return @__env.CallIntMethod(this, _describeContents6958); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.ForegroundColorSpan.staticClass, _describeContents6958); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId6959; 
		public virtual int getSpanTypeId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.ForegroundColorSpan)) 
				return @__env.CallIntMethod(this, _getSpanTypeId6959); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.ForegroundColorSpan.staticClass, _getSpanTypeId6959); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateDrawState6960; 
		public override void updateDrawState(android.text.TextPaint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.ForegroundColorSpan)) 
				@__env.CallVoidMethod(this, _updateDrawState6960, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.ForegroundColorSpan.staticClass, _updateDrawState6960, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getForegroundColor6961; 
		public virtual int getForegroundColor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.ForegroundColorSpan)) 
				return @__env.CallIntMethod(this, _getForegroundColor6961); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.ForegroundColorSpan.staticClass, _getForegroundColor6961); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ForegroundColorSpan6962; 
		public ForegroundColorSpan(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.ForegroundColorSpan.staticClass, _ForegroundColorSpan6962, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ForegroundColorSpan6963; 
		public ForegroundColorSpan(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.ForegroundColorSpan.staticClass, _ForegroundColorSpan6963, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.style.ForegroundColorSpan.staticClass = @__class; 
			global::android.text.style.ForegroundColorSpan._writeToParcel6957 = @__env.GetMethodID(global::android.text.style.ForegroundColorSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.text.style.ForegroundColorSpan._describeContents6958 = @__env.GetMethodID(global::android.text.style.ForegroundColorSpan.staticClass, "describeContents", "()I"); 
			global::android.text.style.ForegroundColorSpan._getSpanTypeId6959 = @__env.GetMethodID(global::android.text.style.ForegroundColorSpan.staticClass, "getSpanTypeId", "()I"); 
			global::android.text.style.ForegroundColorSpan._updateDrawState6960 = @__env.GetMethodID(global::android.text.style.ForegroundColorSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V"); 
			global::android.text.style.ForegroundColorSpan._getForegroundColor6961 = @__env.GetMethodID(global::android.text.style.ForegroundColorSpan.staticClass, "getForegroundColor", "()I"); 
			global::android.text.style.ForegroundColorSpan._ForegroundColorSpan6962 = @__env.GetMethodID(global::android.text.style.ForegroundColorSpan.staticClass, "<init>", "(I)V"); 
			global::android.text.style.ForegroundColorSpan._ForegroundColorSpan6963 = @__env.GetMethodID(global::android.text.style.ForegroundColorSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 
