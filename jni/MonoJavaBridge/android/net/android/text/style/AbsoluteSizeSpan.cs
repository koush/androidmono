namespace android.text.style 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AbsoluteSizeSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{ 
		internal new static global::java.lang.Class staticClass; 
		static AbsoluteSizeSpan() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.style.AbsoluteSizeSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _getSize6907; 
		public virtual int getSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.AbsoluteSizeSpan)) 
				return @__env.CallIntMethod(this, _getSize6907); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.AbsoluteSizeSpan.staticClass, _getSize6907); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel6908; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.AbsoluteSizeSpan)) 
				@__env.CallVoidMethod(this, _writeToParcel6908, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.AbsoluteSizeSpan.staticClass, _writeToParcel6908, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents6909; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.AbsoluteSizeSpan)) 
				return @__env.CallIntMethod(this, _describeContents6909); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.AbsoluteSizeSpan.staticClass, _describeContents6909); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId6910; 
		public virtual int getSpanTypeId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.AbsoluteSizeSpan)) 
				return @__env.CallIntMethod(this, _getSpanTypeId6910); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.AbsoluteSizeSpan.staticClass, _getSpanTypeId6910); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateDrawState6911; 
		public override void updateDrawState(android.text.TextPaint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.AbsoluteSizeSpan)) 
				@__env.CallVoidMethod(this, _updateDrawState6911, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.AbsoluteSizeSpan.staticClass, _updateDrawState6911, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDip6912; 
		public virtual bool getDip() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.AbsoluteSizeSpan)) 
				return @__env.CallBooleanMethod(this, _getDip6912); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.style.AbsoluteSizeSpan.staticClass, _getDip6912); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateMeasureState6913; 
		public override void updateMeasureState(android.text.TextPaint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.AbsoluteSizeSpan)) 
				@__env.CallVoidMethod(this, _updateMeasureState6913, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.AbsoluteSizeSpan.staticClass, _updateMeasureState6913, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AbsoluteSizeSpan6914; 
		public AbsoluteSizeSpan(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.AbsoluteSizeSpan.staticClass, _AbsoluteSizeSpan6914, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AbsoluteSizeSpan6915; 
		public AbsoluteSizeSpan(int arg0, bool arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.AbsoluteSizeSpan.staticClass, _AbsoluteSizeSpan6915, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AbsoluteSizeSpan6916; 
		public AbsoluteSizeSpan(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.AbsoluteSizeSpan.staticClass, _AbsoluteSizeSpan6916, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.style.AbsoluteSizeSpan.staticClass = @__class; 
			global::android.text.style.AbsoluteSizeSpan._getSize6907 = @__env.GetMethodID(global::android.text.style.AbsoluteSizeSpan.staticClass, "getSize", "()I"); 
			global::android.text.style.AbsoluteSizeSpan._writeToParcel6908 = @__env.GetMethodID(global::android.text.style.AbsoluteSizeSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.text.style.AbsoluteSizeSpan._describeContents6909 = @__env.GetMethodID(global::android.text.style.AbsoluteSizeSpan.staticClass, "describeContents", "()I"); 
			global::android.text.style.AbsoluteSizeSpan._getSpanTypeId6910 = @__env.GetMethodID(global::android.text.style.AbsoluteSizeSpan.staticClass, "getSpanTypeId", "()I"); 
			global::android.text.style.AbsoluteSizeSpan._updateDrawState6911 = @__env.GetMethodID(global::android.text.style.AbsoluteSizeSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V"); 
			global::android.text.style.AbsoluteSizeSpan._getDip6912 = @__env.GetMethodID(global::android.text.style.AbsoluteSizeSpan.staticClass, "getDip", "()Z"); 
			global::android.text.style.AbsoluteSizeSpan._updateMeasureState6913 = @__env.GetMethodID(global::android.text.style.AbsoluteSizeSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V"); 
			global::android.text.style.AbsoluteSizeSpan._AbsoluteSizeSpan6914 = @__env.GetMethodID(global::android.text.style.AbsoluteSizeSpan.staticClass, "<init>", "(I)V"); 
			global::android.text.style.AbsoluteSizeSpan._AbsoluteSizeSpan6915 = @__env.GetMethodID(global::android.text.style.AbsoluteSizeSpan.staticClass, "<init>", "(IZ)V"); 
			global::android.text.style.AbsoluteSizeSpan._AbsoluteSizeSpan6916 = @__env.GetMethodID(global::android.text.style.AbsoluteSizeSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 
