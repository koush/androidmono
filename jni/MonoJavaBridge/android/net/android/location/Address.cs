namespace android.location 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Address : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Address() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.location.Address), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.location.Address(@__env); 
			} 
		} 
		protected Address(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString3972; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString3972)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.location.Address.staticClass, _toString3972)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocality3973; 
		public virtual java.lang.String getLocality() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getLocality3973)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.location.Address.staticClass, _getLocality3973)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel3974; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				@__env.CallVoidMethod(this, _writeToParcel3974, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Address.staticClass, _writeToParcel3974, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents3975; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				return @__env.CallIntMethod(this, _describeContents3975); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.location.Address.staticClass, _describeContents3975); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getExtras3976; 
		public virtual android.os.Bundle getExtras() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, _getExtras3976)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.location.Address.staticClass, _getExtras3976)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocale3977; 
		public virtual java.util.Locale getLocale() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Locale>(@__env, @__env.CallObjectMethodPtr(this, _getLocale3977)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Locale>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.location.Address.staticClass, _getLocale3977)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaxAddressLineIndex3978; 
		public virtual int getMaxAddressLineIndex() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				return @__env.CallIntMethod(this, _getMaxAddressLineIndex3978); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.location.Address.staticClass, _getMaxAddressLineIndex3978); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAddressLine3979; 
		public virtual java.lang.String getAddressLine(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getAddressLine3979, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.location.Address.staticClass, _getAddressLine3979, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAddressLine3980; 
		public virtual void setAddressLine(int arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				@__env.CallVoidMethod(this, _setAddressLine3980, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Address.staticClass, _setAddressLine3980, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFeatureName3981; 
		public virtual java.lang.String getFeatureName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getFeatureName3981)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.location.Address.staticClass, _getFeatureName3981)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureName3982; 
		public virtual void setFeatureName(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				@__env.CallVoidMethod(this, _setFeatureName3982, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Address.staticClass, _setFeatureName3982, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAdminArea3983; 
		public virtual java.lang.String getAdminArea() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getAdminArea3983)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.location.Address.staticClass, _getAdminArea3983)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAdminArea3984; 
		public virtual void setAdminArea(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				@__env.CallVoidMethod(this, _setAdminArea3984, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Address.staticClass, _setAdminArea3984, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSubAdminArea3985; 
		public virtual java.lang.String getSubAdminArea() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getSubAdminArea3985)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.location.Address.staticClass, _getSubAdminArea3985)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSubAdminArea3986; 
		public virtual void setSubAdminArea(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				@__env.CallVoidMethod(this, _setSubAdminArea3986, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Address.staticClass, _setSubAdminArea3986, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLocality3987; 
		public virtual void setLocality(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				@__env.CallVoidMethod(this, _setLocality3987, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Address.staticClass, _setLocality3987, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSubLocality3988; 
		public virtual java.lang.String getSubLocality() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getSubLocality3988)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.location.Address.staticClass, _getSubLocality3988)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSubLocality3989; 
		public virtual void setSubLocality(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				@__env.CallVoidMethod(this, _setSubLocality3989, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Address.staticClass, _setSubLocality3989, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getThoroughfare3990; 
		public virtual java.lang.String getThoroughfare() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getThoroughfare3990)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.location.Address.staticClass, _getThoroughfare3990)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setThoroughfare3991; 
		public virtual void setThoroughfare(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				@__env.CallVoidMethod(this, _setThoroughfare3991, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Address.staticClass, _setThoroughfare3991, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSubThoroughfare3992; 
		public virtual java.lang.String getSubThoroughfare() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getSubThoroughfare3992)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.location.Address.staticClass, _getSubThoroughfare3992)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSubThoroughfare3993; 
		public virtual void setSubThoroughfare(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				@__env.CallVoidMethod(this, _setSubThoroughfare3993, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Address.staticClass, _setSubThoroughfare3993, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPremises3994; 
		public virtual java.lang.String getPremises() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getPremises3994)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.location.Address.staticClass, _getPremises3994)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPremises3995; 
		public virtual void setPremises(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				@__env.CallVoidMethod(this, _setPremises3995, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Address.staticClass, _setPremises3995, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPostalCode3996; 
		public virtual java.lang.String getPostalCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getPostalCode3996)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.location.Address.staticClass, _getPostalCode3996)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPostalCode3997; 
		public virtual void setPostalCode(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				@__env.CallVoidMethod(this, _setPostalCode3997, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Address.staticClass, _setPostalCode3997, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCountryCode3998; 
		public virtual java.lang.String getCountryCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getCountryCode3998)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.location.Address.staticClass, _getCountryCode3998)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCountryCode3999; 
		public virtual void setCountryCode(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				@__env.CallVoidMethod(this, _setCountryCode3999, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Address.staticClass, _setCountryCode3999, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCountryName4000; 
		public virtual java.lang.String getCountryName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getCountryName4000)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.location.Address.staticClass, _getCountryName4000)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCountryName4001; 
		public virtual void setCountryName(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				@__env.CallVoidMethod(this, _setCountryName4001, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Address.staticClass, _setCountryName4001, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasLatitude4002; 
		public virtual bool hasLatitude() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				return @__env.CallBooleanMethod(this, _hasLatitude4002); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.location.Address.staticClass, _hasLatitude4002); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLatitude4003; 
		public virtual double getLatitude() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				return @__env.CallDoubleMethod(this, _getLatitude4003); 
			else 
				return @__env.CallNonVirtualDoubleMethod(this, android.location.Address.staticClass, _getLatitude4003); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLatitude4004; 
		public virtual void setLatitude(double arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				@__env.CallVoidMethod(this, _setLatitude4004, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Address.staticClass, _setLatitude4004, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearLatitude4005; 
		public virtual void clearLatitude() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				@__env.CallVoidMethod(this, _clearLatitude4005); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Address.staticClass, _clearLatitude4005); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasLongitude4006; 
		public virtual bool hasLongitude() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				return @__env.CallBooleanMethod(this, _hasLongitude4006); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.location.Address.staticClass, _hasLongitude4006); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLongitude4007; 
		public virtual double getLongitude() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				return @__env.CallDoubleMethod(this, _getLongitude4007); 
			else 
				return @__env.CallNonVirtualDoubleMethod(this, android.location.Address.staticClass, _getLongitude4007); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLongitude4008; 
		public virtual void setLongitude(double arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				@__env.CallVoidMethod(this, _setLongitude4008, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Address.staticClass, _setLongitude4008, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearLongitude4009; 
		public virtual void clearLongitude() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				@__env.CallVoidMethod(this, _clearLongitude4009); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Address.staticClass, _clearLongitude4009); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPhone4010; 
		public virtual java.lang.String getPhone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getPhone4010)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.location.Address.staticClass, _getPhone4010)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPhone4011; 
		public virtual void setPhone(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				@__env.CallVoidMethod(this, _setPhone4011, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Address.staticClass, _setPhone4011, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUrl4012; 
		public virtual java.lang.String getUrl() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getUrl4012)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.location.Address.staticClass, _getUrl4012)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setUrl4013; 
		public virtual void setUrl(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				@__env.CallVoidMethod(this, _setUrl4013, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Address.staticClass, _setUrl4013, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setExtras4014; 
		public virtual void setExtras(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.location.Address)) 
				@__env.CallVoidMethod(this, _setExtras4014, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.location.Address.staticClass, _setExtras4014, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Address4015; 
		public Address(java.util.Locale arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.location.Address.staticClass, _Address4015, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR4016; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.location.Address.staticClass = @__class; 
			global::android.location.Address._toString3972 = @__env.GetMethodID(global::android.location.Address.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.location.Address._getLocality3973 = @__env.GetMethodID(global::android.location.Address.staticClass, "getLocality", "()Ljava/lang/String;"); 
			global::android.location.Address._writeToParcel3974 = @__env.GetMethodID(global::android.location.Address.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.location.Address._describeContents3975 = @__env.GetMethodID(global::android.location.Address.staticClass, "describeContents", "()I"); 
			global::android.location.Address._getExtras3976 = @__env.GetMethodID(global::android.location.Address.staticClass, "getExtras", "()Landroid/os/Bundle;"); 
			global::android.location.Address._getLocale3977 = @__env.GetMethodID(global::android.location.Address.staticClass, "getLocale", "()Ljava/util/Locale;"); 
			global::android.location.Address._getMaxAddressLineIndex3978 = @__env.GetMethodID(global::android.location.Address.staticClass, "getMaxAddressLineIndex", "()I"); 
			global::android.location.Address._getAddressLine3979 = @__env.GetMethodID(global::android.location.Address.staticClass, "getAddressLine", "(I)Ljava/lang/String;"); 
			global::android.location.Address._setAddressLine3980 = @__env.GetMethodID(global::android.location.Address.staticClass, "setAddressLine", "(ILjava/lang/String;)V"); 
			global::android.location.Address._getFeatureName3981 = @__env.GetMethodID(global::android.location.Address.staticClass, "getFeatureName", "()Ljava/lang/String;"); 
			global::android.location.Address._setFeatureName3982 = @__env.GetMethodID(global::android.location.Address.staticClass, "setFeatureName", "(Ljava/lang/String;)V"); 
			global::android.location.Address._getAdminArea3983 = @__env.GetMethodID(global::android.location.Address.staticClass, "getAdminArea", "()Ljava/lang/String;"); 
			global::android.location.Address._setAdminArea3984 = @__env.GetMethodID(global::android.location.Address.staticClass, "setAdminArea", "(Ljava/lang/String;)V"); 
			global::android.location.Address._getSubAdminArea3985 = @__env.GetMethodID(global::android.location.Address.staticClass, "getSubAdminArea", "()Ljava/lang/String;"); 
			global::android.location.Address._setSubAdminArea3986 = @__env.GetMethodID(global::android.location.Address.staticClass, "setSubAdminArea", "(Ljava/lang/String;)V"); 
			global::android.location.Address._setLocality3987 = @__env.GetMethodID(global::android.location.Address.staticClass, "setLocality", "(Ljava/lang/String;)V"); 
			global::android.location.Address._getSubLocality3988 = @__env.GetMethodID(global::android.location.Address.staticClass, "getSubLocality", "()Ljava/lang/String;"); 
			global::android.location.Address._setSubLocality3989 = @__env.GetMethodID(global::android.location.Address.staticClass, "setSubLocality", "(Ljava/lang/String;)V"); 
			global::android.location.Address._getThoroughfare3990 = @__env.GetMethodID(global::android.location.Address.staticClass, "getThoroughfare", "()Ljava/lang/String;"); 
			global::android.location.Address._setThoroughfare3991 = @__env.GetMethodID(global::android.location.Address.staticClass, "setThoroughfare", "(Ljava/lang/String;)V"); 
			global::android.location.Address._getSubThoroughfare3992 = @__env.GetMethodID(global::android.location.Address.staticClass, "getSubThoroughfare", "()Ljava/lang/String;"); 
			global::android.location.Address._setSubThoroughfare3993 = @__env.GetMethodID(global::android.location.Address.staticClass, "setSubThoroughfare", "(Ljava/lang/String;)V"); 
			global::android.location.Address._getPremises3994 = @__env.GetMethodID(global::android.location.Address.staticClass, "getPremises", "()Ljava/lang/String;"); 
			global::android.location.Address._setPremises3995 = @__env.GetMethodID(global::android.location.Address.staticClass, "setPremises", "(Ljava/lang/String;)V"); 
			global::android.location.Address._getPostalCode3996 = @__env.GetMethodID(global::android.location.Address.staticClass, "getPostalCode", "()Ljava/lang/String;"); 
			global::android.location.Address._setPostalCode3997 = @__env.GetMethodID(global::android.location.Address.staticClass, "setPostalCode", "(Ljava/lang/String;)V"); 
			global::android.location.Address._getCountryCode3998 = @__env.GetMethodID(global::android.location.Address.staticClass, "getCountryCode", "()Ljava/lang/String;"); 
			global::android.location.Address._setCountryCode3999 = @__env.GetMethodID(global::android.location.Address.staticClass, "setCountryCode", "(Ljava/lang/String;)V"); 
			global::android.location.Address._getCountryName4000 = @__env.GetMethodID(global::android.location.Address.staticClass, "getCountryName", "()Ljava/lang/String;"); 
			global::android.location.Address._setCountryName4001 = @__env.GetMethodID(global::android.location.Address.staticClass, "setCountryName", "(Ljava/lang/String;)V"); 
			global::android.location.Address._hasLatitude4002 = @__env.GetMethodID(global::android.location.Address.staticClass, "hasLatitude", "()Z"); 
			global::android.location.Address._getLatitude4003 = @__env.GetMethodID(global::android.location.Address.staticClass, "getLatitude", "()D"); 
			global::android.location.Address._setLatitude4004 = @__env.GetMethodID(global::android.location.Address.staticClass, "setLatitude", "(D)V"); 
			global::android.location.Address._clearLatitude4005 = @__env.GetMethodID(global::android.location.Address.staticClass, "clearLatitude", "()V"); 
			global::android.location.Address._hasLongitude4006 = @__env.GetMethodID(global::android.location.Address.staticClass, "hasLongitude", "()Z"); 
			global::android.location.Address._getLongitude4007 = @__env.GetMethodID(global::android.location.Address.staticClass, "getLongitude", "()D"); 
			global::android.location.Address._setLongitude4008 = @__env.GetMethodID(global::android.location.Address.staticClass, "setLongitude", "(D)V"); 
			global::android.location.Address._clearLongitude4009 = @__env.GetMethodID(global::android.location.Address.staticClass, "clearLongitude", "()V"); 
			global::android.location.Address._getPhone4010 = @__env.GetMethodID(global::android.location.Address.staticClass, "getPhone", "()Ljava/lang/String;"); 
			global::android.location.Address._setPhone4011 = @__env.GetMethodID(global::android.location.Address.staticClass, "setPhone", "(Ljava/lang/String;)V"); 
			global::android.location.Address._getUrl4012 = @__env.GetMethodID(global::android.location.Address.staticClass, "getUrl", "()Ljava/lang/String;"); 
			global::android.location.Address._setUrl4013 = @__env.GetMethodID(global::android.location.Address.staticClass, "setUrl", "(Ljava/lang/String;)V"); 
			global::android.location.Address._setExtras4014 = @__env.GetMethodID(global::android.location.Address.staticClass, "setExtras", "(Landroid/os/Bundle;)V"); 
			global::android.location.Address._Address4015 = @__env.GetMethodID(global::android.location.Address.staticClass, "<init>", "(Ljava/util/Locale;)V"); 
		} 
	} 
} 
