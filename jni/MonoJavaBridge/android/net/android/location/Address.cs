namespace android.location 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Address : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Address() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.location.Address), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _toString4195; 
		public override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._toString4195)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._toString4195)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocality4196; 
		public virtual global::java.lang.String getLocality() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._getLocality4196)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._getLocality4196)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel4197; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.location.Address._writeToParcel4197, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._writeToParcel4197, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents4198; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.location.Address._describeContents4198); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.location.Address.staticClass, global::android.location.Address._describeContents4198); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getExtras4199; 
		public virtual global::android.os.Bundle getExtras() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._getExtras4199)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._getExtras4199)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocale4200; 
		public virtual global::java.util.Locale getLocale() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Locale>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._getLocale4200)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Locale>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._getLocale4200)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaxAddressLineIndex4201; 
		public virtual int getMaxAddressLineIndex() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.location.Address._getMaxAddressLineIndex4201); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.location.Address.staticClass, global::android.location.Address._getMaxAddressLineIndex4201); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAddressLine4202; 
		public virtual global::java.lang.String getAddressLine(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._getAddressLine4202, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._getAddressLine4202, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAddressLine4203; 
		public virtual void setAddressLine(int arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.location.Address._setAddressLine4203, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setAddressLine4203, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFeatureName4204; 
		public virtual global::java.lang.String getFeatureName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._getFeatureName4204)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._getFeatureName4204)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureName4205; 
		public virtual void setFeatureName(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.location.Address._setFeatureName4205, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setFeatureName4205, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAdminArea4206; 
		public virtual global::java.lang.String getAdminArea() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._getAdminArea4206)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._getAdminArea4206)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAdminArea4207; 
		public virtual void setAdminArea(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.location.Address._setAdminArea4207, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setAdminArea4207, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSubAdminArea4208; 
		public virtual global::java.lang.String getSubAdminArea() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._getSubAdminArea4208)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._getSubAdminArea4208)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSubAdminArea4209; 
		public virtual void setSubAdminArea(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.location.Address._setSubAdminArea4209, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setSubAdminArea4209, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLocality4210; 
		public virtual void setLocality(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.location.Address._setLocality4210, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setLocality4210, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSubLocality4211; 
		public virtual global::java.lang.String getSubLocality() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._getSubLocality4211)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._getSubLocality4211)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSubLocality4212; 
		public virtual void setSubLocality(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.location.Address._setSubLocality4212, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setSubLocality4212, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getThoroughfare4213; 
		public virtual global::java.lang.String getThoroughfare() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._getThoroughfare4213)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._getThoroughfare4213)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setThoroughfare4214; 
		public virtual void setThoroughfare(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.location.Address._setThoroughfare4214, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setThoroughfare4214, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSubThoroughfare4215; 
		public virtual global::java.lang.String getSubThoroughfare() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._getSubThoroughfare4215)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._getSubThoroughfare4215)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSubThoroughfare4216; 
		public virtual void setSubThoroughfare(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.location.Address._setSubThoroughfare4216, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setSubThoroughfare4216, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPremises4217; 
		public virtual global::java.lang.String getPremises() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._getPremises4217)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._getPremises4217)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPremises4218; 
		public virtual void setPremises(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.location.Address._setPremises4218, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setPremises4218, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPostalCode4219; 
		public virtual global::java.lang.String getPostalCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._getPostalCode4219)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._getPostalCode4219)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPostalCode4220; 
		public virtual void setPostalCode(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.location.Address._setPostalCode4220, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setPostalCode4220, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCountryCode4221; 
		public virtual global::java.lang.String getCountryCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._getCountryCode4221)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._getCountryCode4221)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCountryCode4222; 
		public virtual void setCountryCode(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.location.Address._setCountryCode4222, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setCountryCode4222, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCountryName4223; 
		public virtual global::java.lang.String getCountryName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._getCountryName4223)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._getCountryName4223)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCountryName4224; 
		public virtual void setCountryName(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.location.Address._setCountryName4224, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setCountryName4224, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasLatitude4225; 
		public virtual bool hasLatitude() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.location.Address._hasLatitude4225); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.location.Address.staticClass, global::android.location.Address._hasLatitude4225); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLatitude4226; 
		public virtual double getLatitude() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallDoubleMethod(this, global::android.location.Address._getLatitude4226); 
			else 
				return @__env.CallNonVirtualDoubleMethod(this, global::android.location.Address.staticClass, global::android.location.Address._getLatitude4226); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLatitude4227; 
		public virtual void setLatitude(double arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.location.Address._setLatitude4227, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setLatitude4227, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearLatitude4228; 
		public virtual void clearLatitude() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.location.Address._clearLatitude4228); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._clearLatitude4228); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasLongitude4229; 
		public virtual bool hasLongitude() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.location.Address._hasLongitude4229); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.location.Address.staticClass, global::android.location.Address._hasLongitude4229); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLongitude4230; 
		public virtual double getLongitude() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallDoubleMethod(this, global::android.location.Address._getLongitude4230); 
			else 
				return @__env.CallNonVirtualDoubleMethod(this, global::android.location.Address.staticClass, global::android.location.Address._getLongitude4230); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLongitude4231; 
		public virtual void setLongitude(double arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.location.Address._setLongitude4231, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setLongitude4231, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearLongitude4232; 
		public virtual void clearLongitude() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.location.Address._clearLongitude4232); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._clearLongitude4232); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPhone4233; 
		public virtual global::java.lang.String getPhone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._getPhone4233)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._getPhone4233)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPhone4234; 
		public virtual void setPhone(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.location.Address._setPhone4234, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setPhone4234, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUrl4235; 
		public virtual global::java.lang.String getUrl() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._getUrl4235)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._getUrl4235)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setUrl4236; 
		public virtual void setUrl(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.location.Address._setUrl4236, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setUrl4236, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setExtras4237; 
		public virtual void setExtras(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.location.Address._setExtras4237, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setExtras4237, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Address4238; 
		public Address(java.util.Locale arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.location.Address.staticClass, global::android.location.Address._Address4238, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR4239; 
		public static global::android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(global::android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.location.Address.staticClass = @__class; 
			global::android.location.Address._toString4195 = @__env.GetMethodID(global::android.location.Address.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.location.Address._getLocality4196 = @__env.GetMethodID(global::android.location.Address.staticClass, "getLocality", "()Ljava/lang/String;"); 
			global::android.location.Address._writeToParcel4197 = @__env.GetMethodID(global::android.location.Address.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.location.Address._describeContents4198 = @__env.GetMethodID(global::android.location.Address.staticClass, "describeContents", "()I"); 
			global::android.location.Address._getExtras4199 = @__env.GetMethodID(global::android.location.Address.staticClass, "getExtras", "()Landroid/os/Bundle;"); 
			global::android.location.Address._getLocale4200 = @__env.GetMethodID(global::android.location.Address.staticClass, "getLocale", "()Ljava/util/Locale;"); 
			global::android.location.Address._getMaxAddressLineIndex4201 = @__env.GetMethodID(global::android.location.Address.staticClass, "getMaxAddressLineIndex", "()I"); 
			global::android.location.Address._getAddressLine4202 = @__env.GetMethodID(global::android.location.Address.staticClass, "getAddressLine", "(I)Ljava/lang/String;"); 
			global::android.location.Address._setAddressLine4203 = @__env.GetMethodID(global::android.location.Address.staticClass, "setAddressLine", "(ILjava/lang/String;)V"); 
			global::android.location.Address._getFeatureName4204 = @__env.GetMethodID(global::android.location.Address.staticClass, "getFeatureName", "()Ljava/lang/String;"); 
			global::android.location.Address._setFeatureName4205 = @__env.GetMethodID(global::android.location.Address.staticClass, "setFeatureName", "(Ljava/lang/String;)V"); 
			global::android.location.Address._getAdminArea4206 = @__env.GetMethodID(global::android.location.Address.staticClass, "getAdminArea", "()Ljava/lang/String;"); 
			global::android.location.Address._setAdminArea4207 = @__env.GetMethodID(global::android.location.Address.staticClass, "setAdminArea", "(Ljava/lang/String;)V"); 
			global::android.location.Address._getSubAdminArea4208 = @__env.GetMethodID(global::android.location.Address.staticClass, "getSubAdminArea", "()Ljava/lang/String;"); 
			global::android.location.Address._setSubAdminArea4209 = @__env.GetMethodID(global::android.location.Address.staticClass, "setSubAdminArea", "(Ljava/lang/String;)V"); 
			global::android.location.Address._setLocality4210 = @__env.GetMethodID(global::android.location.Address.staticClass, "setLocality", "(Ljava/lang/String;)V"); 
			global::android.location.Address._getSubLocality4211 = @__env.GetMethodID(global::android.location.Address.staticClass, "getSubLocality", "()Ljava/lang/String;"); 
			global::android.location.Address._setSubLocality4212 = @__env.GetMethodID(global::android.location.Address.staticClass, "setSubLocality", "(Ljava/lang/String;)V"); 
			global::android.location.Address._getThoroughfare4213 = @__env.GetMethodID(global::android.location.Address.staticClass, "getThoroughfare", "()Ljava/lang/String;"); 
			global::android.location.Address._setThoroughfare4214 = @__env.GetMethodID(global::android.location.Address.staticClass, "setThoroughfare", "(Ljava/lang/String;)V"); 
			global::android.location.Address._getSubThoroughfare4215 = @__env.GetMethodID(global::android.location.Address.staticClass, "getSubThoroughfare", "()Ljava/lang/String;"); 
			global::android.location.Address._setSubThoroughfare4216 = @__env.GetMethodID(global::android.location.Address.staticClass, "setSubThoroughfare", "(Ljava/lang/String;)V"); 
			global::android.location.Address._getPremises4217 = @__env.GetMethodID(global::android.location.Address.staticClass, "getPremises", "()Ljava/lang/String;"); 
			global::android.location.Address._setPremises4218 = @__env.GetMethodID(global::android.location.Address.staticClass, "setPremises", "(Ljava/lang/String;)V"); 
			global::android.location.Address._getPostalCode4219 = @__env.GetMethodID(global::android.location.Address.staticClass, "getPostalCode", "()Ljava/lang/String;"); 
			global::android.location.Address._setPostalCode4220 = @__env.GetMethodID(global::android.location.Address.staticClass, "setPostalCode", "(Ljava/lang/String;)V"); 
			global::android.location.Address._getCountryCode4221 = @__env.GetMethodID(global::android.location.Address.staticClass, "getCountryCode", "()Ljava/lang/String;"); 
			global::android.location.Address._setCountryCode4222 = @__env.GetMethodID(global::android.location.Address.staticClass, "setCountryCode", "(Ljava/lang/String;)V"); 
			global::android.location.Address._getCountryName4223 = @__env.GetMethodID(global::android.location.Address.staticClass, "getCountryName", "()Ljava/lang/String;"); 
			global::android.location.Address._setCountryName4224 = @__env.GetMethodID(global::android.location.Address.staticClass, "setCountryName", "(Ljava/lang/String;)V"); 
			global::android.location.Address._hasLatitude4225 = @__env.GetMethodID(global::android.location.Address.staticClass, "hasLatitude", "()Z"); 
			global::android.location.Address._getLatitude4226 = @__env.GetMethodID(global::android.location.Address.staticClass, "getLatitude", "()D"); 
			global::android.location.Address._setLatitude4227 = @__env.GetMethodID(global::android.location.Address.staticClass, "setLatitude", "(D)V"); 
			global::android.location.Address._clearLatitude4228 = @__env.GetMethodID(global::android.location.Address.staticClass, "clearLatitude", "()V"); 
			global::android.location.Address._hasLongitude4229 = @__env.GetMethodID(global::android.location.Address.staticClass, "hasLongitude", "()Z"); 
			global::android.location.Address._getLongitude4230 = @__env.GetMethodID(global::android.location.Address.staticClass, "getLongitude", "()D"); 
			global::android.location.Address._setLongitude4231 = @__env.GetMethodID(global::android.location.Address.staticClass, "setLongitude", "(D)V"); 
			global::android.location.Address._clearLongitude4232 = @__env.GetMethodID(global::android.location.Address.staticClass, "clearLongitude", "()V"); 
			global::android.location.Address._getPhone4233 = @__env.GetMethodID(global::android.location.Address.staticClass, "getPhone", "()Ljava/lang/String;"); 
			global::android.location.Address._setPhone4234 = @__env.GetMethodID(global::android.location.Address.staticClass, "setPhone", "(Ljava/lang/String;)V"); 
			global::android.location.Address._getUrl4235 = @__env.GetMethodID(global::android.location.Address.staticClass, "getUrl", "()Ljava/lang/String;"); 
			global::android.location.Address._setUrl4236 = @__env.GetMethodID(global::android.location.Address.staticClass, "setUrl", "(Ljava/lang/String;)V"); 
			global::android.location.Address._setExtras4237 = @__env.GetMethodID(global::android.location.Address.staticClass, "setExtras", "(Landroid/os/Bundle;)V"); 
			global::android.location.Address._Address4238 = @__env.GetMethodID(global::android.location.Address.staticClass, "<init>", "(Ljava/util/Locale;)V"); 
		} 
	} 
} 
