namespace android.text.style 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class BackgroundColorSpan : android.text.style.CharacterStyle, UpdateAppearance, ParcelableSpan
	{ 
		internal new static global::java.lang.Class staticClass; 
		static BackgroundColorSpan() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.style.BackgroundColorSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.style.BackgroundColorSpan(@__env); 
			} 
		} 
		protected BackgroundColorSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel6923; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.BackgroundColorSpan)) 
				@__env.CallVoidMethod(this, _writeToParcel6923, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.BackgroundColorSpan.staticClass, _writeToParcel6923, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents6924; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.BackgroundColorSpan)) 
				return @__env.CallIntMethod(this, _describeContents6924); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.BackgroundColorSpan.staticClass, _describeContents6924); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId6925; 
		public virtual int getSpanTypeId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.BackgroundColorSpan)) 
				return @__env.CallIntMethod(this, _getSpanTypeId6925); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.BackgroundColorSpan.staticClass, _getSpanTypeId6925); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateDrawState6926; 
		public override void updateDrawState(android.text.TextPaint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.BackgroundColorSpan)) 
				@__env.CallVoidMethod(this, _updateDrawState6926, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.BackgroundColorSpan.staticClass, _updateDrawState6926, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBackgroundColor6927; 
		public virtual int getBackgroundColor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.BackgroundColorSpan)) 
				return @__env.CallIntMethod(this, _getBackgroundColor6927); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.BackgroundColorSpan.staticClass, _getBackgroundColor6927); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BackgroundColorSpan6928; 
		public BackgroundColorSpan(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.BackgroundColorSpan.staticClass, _BackgroundColorSpan6928, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BackgroundColorSpan6929; 
		public BackgroundColorSpan(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.BackgroundColorSpan.staticClass, _BackgroundColorSpan6929, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.style.BackgroundColorSpan.staticClass = @__class; 
			global::android.text.style.BackgroundColorSpan._writeToParcel6923 = @__env.GetMethodID(global::android.text.style.BackgroundColorSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.text.style.BackgroundColorSpan._describeContents6924 = @__env.GetMethodID(global::android.text.style.BackgroundColorSpan.staticClass, "describeContents", "()I"); 
			global::android.text.style.BackgroundColorSpan._getSpanTypeId6925 = @__env.GetMethodID(global::android.text.style.BackgroundColorSpan.staticClass, "getSpanTypeId", "()I"); 
			global::android.text.style.BackgroundColorSpan._updateDrawState6926 = @__env.GetMethodID(global::android.text.style.BackgroundColorSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V"); 
			global::android.text.style.BackgroundColorSpan._getBackgroundColor6927 = @__env.GetMethodID(global::android.text.style.BackgroundColorSpan.staticClass, "getBackgroundColor", "()I"); 
			global::android.text.style.BackgroundColorSpan._BackgroundColorSpan6928 = @__env.GetMethodID(global::android.text.style.BackgroundColorSpan.staticClass, "<init>", "(I)V"); 
			global::android.text.style.BackgroundColorSpan._BackgroundColorSpan6929 = @__env.GetMethodID(global::android.text.style.BackgroundColorSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 
