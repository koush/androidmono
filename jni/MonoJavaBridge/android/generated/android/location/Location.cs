namespace android.location
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Location : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static Location()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.location.Location), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.location.Location(@__env);
			}
		}
		protected Location(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString4506;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Location._toString4506));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Location.staticClass, global::android.location.Location._toString4506));
		}
		internal static global::net.sf.jni4net.jni.MethodId _set4507;
		public virtual void set(android.location.Location arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Location._set4507, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._set4507, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _reset4508;
		public virtual void reset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Location._reset4508);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._reset4508);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTime4509;
		public virtual void setTime(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Location._setTime4509, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._setTime4509, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getTime4510;
		public virtual long getTime() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.location.Location._getTime4510);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.location.Location.staticClass, global::android.location.Location._getTime4510);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getProvider4511;
		public virtual global::java.lang.String getProvider() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Location._getProvider4511));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Location.staticClass, global::android.location.Location._getProvider4511));
		}
		internal static global::net.sf.jni4net.jni.MethodId _convert4512;
		public static double convert(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticDoubleMethod(android.location.Location.staticClass, global::android.location.Location._convert4512, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _convert4513;
		public static global::java.lang.String convert(double arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.location.Location.staticClass, global::android.location.Location._convert4513, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dump4514;
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Location._dump4514, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._dump4514, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel4515;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Location._writeToParcel4515, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._writeToParcel4515, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents4516;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.location.Location._describeContents4516);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.location.Location.staticClass, global::android.location.Location._describeContents4516);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getExtras4517;
		public virtual global::android.os.Bundle getExtras() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Location._getExtras4517));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Location.staticClass, global::android.location.Location._getExtras4517));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLatitude4518;
		public virtual double getLatitude() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this, global::android.location.Location._getLatitude4518);
			else
				return @__env.CallNonVirtualDoubleMethod(this, global::android.location.Location.staticClass, global::android.location.Location._getLatitude4518);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLatitude4519;
		public virtual void setLatitude(double arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Location._setLatitude4519, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._setLatitude4519, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLongitude4520;
		public virtual double getLongitude() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this, global::android.location.Location._getLongitude4520);
			else
				return @__env.CallNonVirtualDoubleMethod(this, global::android.location.Location.staticClass, global::android.location.Location._getLongitude4520);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLongitude4521;
		public virtual void setLongitude(double arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Location._setLongitude4521, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._setLongitude4521, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setExtras4522;
		public virtual void setExtras(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Location._setExtras4522, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._setExtras4522, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAccuracy4523;
		public virtual void setAccuracy(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Location._setAccuracy4523, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._setAccuracy4523, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAccuracy4524;
		public virtual float getAccuracy() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.location.Location._getAccuracy4524);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.location.Location.staticClass, global::android.location.Location._getAccuracy4524);
		}
		internal static global::net.sf.jni4net.jni.MethodId _distanceBetween4525;
		public static void distanceBetween(double arg0, double arg1, double arg2, double arg3, float[] arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.location.Location.staticClass, global::android.location.Location._distanceBetween4525, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _distanceTo4526;
		public virtual float distanceTo(android.location.Location arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.location.Location._distanceTo4526, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.location.Location.staticClass, global::android.location.Location._distanceTo4526, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _bearingTo4527;
		public virtual float bearingTo(android.location.Location arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.location.Location._bearingTo4527, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.location.Location.staticClass, global::android.location.Location._bearingTo4527, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setProvider4528;
		public virtual void setProvider(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Location._setProvider4528, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._setProvider4528, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasAltitude4529;
		public virtual bool hasAltitude() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.location.Location._hasAltitude4529);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.location.Location.staticClass, global::android.location.Location._hasAltitude4529);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAltitude4530;
		public virtual double getAltitude() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this, global::android.location.Location._getAltitude4530);
			else
				return @__env.CallNonVirtualDoubleMethod(this, global::android.location.Location.staticClass, global::android.location.Location._getAltitude4530);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAltitude4531;
		public virtual void setAltitude(double arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Location._setAltitude4531, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._setAltitude4531, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeAltitude4532;
		public virtual void removeAltitude() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Location._removeAltitude4532);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._removeAltitude4532);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasSpeed4533;
		public virtual bool hasSpeed() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.location.Location._hasSpeed4533);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.location.Location.staticClass, global::android.location.Location._hasSpeed4533);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSpeed4534;
		public virtual float getSpeed() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.location.Location._getSpeed4534);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.location.Location.staticClass, global::android.location.Location._getSpeed4534);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSpeed4535;
		public virtual void setSpeed(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Location._setSpeed4535, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._setSpeed4535, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeSpeed4536;
		public virtual void removeSpeed() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Location._removeSpeed4536);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._removeSpeed4536);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasBearing4537;
		public virtual bool hasBearing() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.location.Location._hasBearing4537);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.location.Location.staticClass, global::android.location.Location._hasBearing4537);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBearing4538;
		public virtual float getBearing() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.location.Location._getBearing4538);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.location.Location.staticClass, global::android.location.Location._getBearing4538);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setBearing4539;
		public virtual void setBearing(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Location._setBearing4539, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._setBearing4539, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeBearing4540;
		public virtual void removeBearing() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Location._removeBearing4540);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._removeBearing4540);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasAccuracy4541;
		public virtual bool hasAccuracy() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.location.Location._hasAccuracy4541);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.location.Location.staticClass, global::android.location.Location._hasAccuracy4541);
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeAccuracy4542;
		public virtual void removeAccuracy() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Location._removeAccuracy4542);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Location.staticClass, global::android.location.Location._removeAccuracy4542);
		}
		internal static global::net.sf.jni4net.jni.MethodId _Location4543;
		public Location(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.location.Location.staticClass, global::android.location.Location._Location4543, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Location4544;
		public Location(android.location.Location arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.location.Location.staticClass, global::android.location.Location._Location4544, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		public static int FORMAT_DEGREES
		{
			get
			{
				return 0;
			}
		}
		public static int FORMAT_MINUTES
		{
			get
			{
				return 1;
			}
		}
		public static int FORMAT_SECONDS
		{
			get
			{
				return 2;
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR4545;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.location.Location.staticClass = @__class;
			global::android.location.Location._toString4506 = @__env.GetMethodID(global::android.location.Location.staticClass, "toString", "()Ljava/lang/String;");
			global::android.location.Location._set4507 = @__env.GetMethodID(global::android.location.Location.staticClass, "set", "(Landroid/location/Location;)V");
			global::android.location.Location._reset4508 = @__env.GetMethodID(global::android.location.Location.staticClass, "reset", "()V");
			global::android.location.Location._setTime4509 = @__env.GetMethodID(global::android.location.Location.staticClass, "setTime", "(J)V");
			global::android.location.Location._getTime4510 = @__env.GetMethodID(global::android.location.Location.staticClass, "getTime", "()J");
			global::android.location.Location._getProvider4511 = @__env.GetMethodID(global::android.location.Location.staticClass, "getProvider", "()Ljava/lang/String;");
			global::android.location.Location._convert4512 = @__env.GetStaticMethodID(global::android.location.Location.staticClass, "convert", "(Ljava/lang/String;)D");
			global::android.location.Location._convert4513 = @__env.GetStaticMethodID(global::android.location.Location.staticClass, "convert", "(DI)Ljava/lang/String;");
			global::android.location.Location._dump4514 = @__env.GetMethodID(global::android.location.Location.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V");
			global::android.location.Location._writeToParcel4515 = @__env.GetMethodID(global::android.location.Location.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.location.Location._describeContents4516 = @__env.GetMethodID(global::android.location.Location.staticClass, "describeContents", "()I");
			global::android.location.Location._getExtras4517 = @__env.GetMethodID(global::android.location.Location.staticClass, "getExtras", "()Landroid/os/Bundle;");
			global::android.location.Location._getLatitude4518 = @__env.GetMethodID(global::android.location.Location.staticClass, "getLatitude", "()D");
			global::android.location.Location._setLatitude4519 = @__env.GetMethodID(global::android.location.Location.staticClass, "setLatitude", "(D)V");
			global::android.location.Location._getLongitude4520 = @__env.GetMethodID(global::android.location.Location.staticClass, "getLongitude", "()D");
			global::android.location.Location._setLongitude4521 = @__env.GetMethodID(global::android.location.Location.staticClass, "setLongitude", "(D)V");
			global::android.location.Location._setExtras4522 = @__env.GetMethodID(global::android.location.Location.staticClass, "setExtras", "(Landroid/os/Bundle;)V");
			global::android.location.Location._setAccuracy4523 = @__env.GetMethodID(global::android.location.Location.staticClass, "setAccuracy", "(F)V");
			global::android.location.Location._getAccuracy4524 = @__env.GetMethodID(global::android.location.Location.staticClass, "getAccuracy", "()F");
			global::android.location.Location._distanceBetween4525 = @__env.GetStaticMethodID(global::android.location.Location.staticClass, "distanceBetween", "(DDDD[F)V");
			global::android.location.Location._distanceTo4526 = @__env.GetMethodID(global::android.location.Location.staticClass, "distanceTo", "(Landroid/location/Location;)F");
			global::android.location.Location._bearingTo4527 = @__env.GetMethodID(global::android.location.Location.staticClass, "bearingTo", "(Landroid/location/Location;)F");
			global::android.location.Location._setProvider4528 = @__env.GetMethodID(global::android.location.Location.staticClass, "setProvider", "(Ljava/lang/String;)V");
			global::android.location.Location._hasAltitude4529 = @__env.GetMethodID(global::android.location.Location.staticClass, "hasAltitude", "()Z");
			global::android.location.Location._getAltitude4530 = @__env.GetMethodID(global::android.location.Location.staticClass, "getAltitude", "()D");
			global::android.location.Location._setAltitude4531 = @__env.GetMethodID(global::android.location.Location.staticClass, "setAltitude", "(D)V");
			global::android.location.Location._removeAltitude4532 = @__env.GetMethodID(global::android.location.Location.staticClass, "removeAltitude", "()V");
			global::android.location.Location._hasSpeed4533 = @__env.GetMethodID(global::android.location.Location.staticClass, "hasSpeed", "()Z");
			global::android.location.Location._getSpeed4534 = @__env.GetMethodID(global::android.location.Location.staticClass, "getSpeed", "()F");
			global::android.location.Location._setSpeed4535 = @__env.GetMethodID(global::android.location.Location.staticClass, "setSpeed", "(F)V");
			global::android.location.Location._removeSpeed4536 = @__env.GetMethodID(global::android.location.Location.staticClass, "removeSpeed", "()V");
			global::android.location.Location._hasBearing4537 = @__env.GetMethodID(global::android.location.Location.staticClass, "hasBearing", "()Z");
			global::android.location.Location._getBearing4538 = @__env.GetMethodID(global::android.location.Location.staticClass, "getBearing", "()F");
			global::android.location.Location._setBearing4539 = @__env.GetMethodID(global::android.location.Location.staticClass, "setBearing", "(F)V");
			global::android.location.Location._removeBearing4540 = @__env.GetMethodID(global::android.location.Location.staticClass, "removeBearing", "()V");
			global::android.location.Location._hasAccuracy4541 = @__env.GetMethodID(global::android.location.Location.staticClass, "hasAccuracy", "()Z");
			global::android.location.Location._removeAccuracy4542 = @__env.GetMethodID(global::android.location.Location.staticClass, "removeAccuracy", "()V");
			global::android.location.Location._Location4543 = @__env.GetMethodID(global::android.location.Location.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.location.Location._Location4544 = @__env.GetMethodID(global::android.location.Location.staticClass, "<init>", "(Landroid/location/Location;)V");
		}
	}
}
