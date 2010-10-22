namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.CallableStatement_))]
	public interface CallableStatement : PreparedStatement
	{
		global::java.lang.Object getObject(int arg0, java.util.Map arg1);
		global::java.lang.Object getObject(java.lang.String arg0);
		global::java.lang.Object getObject(int arg0);
		global::java.lang.Object getObject(java.lang.String arg0, java.util.Map arg1);
		bool getBoolean(int arg0);
		bool getBoolean(java.lang.String arg0);
		byte getByte(int arg0);
		byte getByte(java.lang.String arg0);
		short getShort(int arg0);
		short getShort(java.lang.String arg0);
		int getInt(java.lang.String arg0);
		int getInt(int arg0);
		long getLong(int arg0);
		long getLong(java.lang.String arg0);
		float getFloat(java.lang.String arg0);
		float getFloat(int arg0);
		double getDouble(java.lang.String arg0);
		double getDouble(int arg0);
		byte[] getBytes(int arg0);
		byte[] getBytes(java.lang.String arg0);
		global::java.sql.Array getArray(int arg0);
		global::java.sql.Array getArray(java.lang.String arg0);
		global::java.net.URL getURL(int arg0);
		global::java.net.URL getURL(java.lang.String arg0);
		void setBoolean(java.lang.String arg0, bool arg1);
		void setByte(java.lang.String arg0, byte arg1);
		void setShort(java.lang.String arg0, short arg1);
		void setInt(java.lang.String arg0, int arg1);
		void setLong(java.lang.String arg0, long arg1);
		void setFloat(java.lang.String arg0, float arg1);
		void setDouble(java.lang.String arg0, double arg1);
		void setTimestamp(java.lang.String arg0, java.sql.Timestamp arg1, java.util.Calendar arg2);
		void setTimestamp(java.lang.String arg0, java.sql.Timestamp arg1);
		global::java.sql.Ref getRef(int arg0);
		global::java.sql.Ref getRef(java.lang.String arg0);
		global::java.lang.String getString(int arg0);
		global::java.lang.String getString(java.lang.String arg0);
		void setURL(java.lang.String arg0, java.net.URL arg1);
		void setTime(java.lang.String arg0, java.sql.Time arg1);
		void setTime(java.lang.String arg0, java.sql.Time arg1, java.util.Calendar arg2);
		global::java.sql.Time getTime(int arg0);
		global::java.sql.Time getTime(java.lang.String arg0);
		global::java.sql.Time getTime(java.lang.String arg0, java.util.Calendar arg1);
		global::java.sql.Time getTime(int arg0, java.util.Calendar arg1);
		global::java.sql.Date getDate(java.lang.String arg0, java.util.Calendar arg1);
		global::java.sql.Date getDate(int arg0, java.util.Calendar arg1);
		global::java.sql.Date getDate(java.lang.String arg0);
		global::java.sql.Date getDate(int arg0);
		global::java.sql.Timestamp getTimestamp(int arg0);
		global::java.sql.Timestamp getTimestamp(java.lang.String arg0, java.util.Calendar arg1);
		global::java.sql.Timestamp getTimestamp(java.lang.String arg0);
		global::java.sql.Timestamp getTimestamp(int arg0, java.util.Calendar arg1);
		void setDate(java.lang.String arg0, java.sql.Date arg1);
		void setDate(java.lang.String arg0, java.sql.Date arg1, java.util.Calendar arg2);
		global::java.sql.Blob getBlob(int arg0);
		global::java.sql.Blob getBlob(java.lang.String arg0);
		void setString(java.lang.String arg0, java.lang.String arg1);
		void setObject(java.lang.String arg0, java.lang.Object arg1);
		void setObject(java.lang.String arg0, java.lang.Object arg1, int arg2);
		void setObject(java.lang.String arg0, java.lang.Object arg1, int arg2, int arg3);
		bool wasNull();
		global::java.math.BigDecimal getBigDecimal(int arg0, int arg1);
		global::java.math.BigDecimal getBigDecimal(java.lang.String arg0);
		global::java.math.BigDecimal getBigDecimal(int arg0);
		global::java.io.Reader getCharacterStream(int arg0);
		global::java.io.Reader getCharacterStream(java.lang.String arg0);
		global::java.sql.Clob getClob(int arg0);
		global::java.sql.Clob getClob(java.lang.String arg0);
		global::java.lang.String getNString(int arg0);
		global::java.lang.String getNString(java.lang.String arg0);
		global::java.io.Reader getNCharacterStream(java.lang.String arg0);
		global::java.io.Reader getNCharacterStream(int arg0);
		void setBytes(java.lang.String arg0, byte[] arg1);
		void setBinaryStream(java.lang.String arg0, java.io.InputStream arg1, int arg2);
		void setBinaryStream(java.lang.String arg0, java.io.InputStream arg1, long arg2);
		void setBinaryStream(java.lang.String arg0, java.io.InputStream arg1);
		void registerOutParameter(int arg0, int arg1, java.lang.String arg2);
		void registerOutParameter(int arg0, int arg1, int arg2);
		void registerOutParameter(int arg0, int arg1);
		void registerOutParameter(java.lang.String arg0, int arg1);
		void registerOutParameter(java.lang.String arg0, int arg1, int arg2);
		void registerOutParameter(java.lang.String arg0, int arg1, java.lang.String arg2);
		void setNull(java.lang.String arg0, int arg1, java.lang.String arg2);
		void setNull(java.lang.String arg0, int arg1);
		void setBigDecimal(java.lang.String arg0, java.math.BigDecimal arg1);
		void setAsciiStream(java.lang.String arg0, java.io.InputStream arg1, int arg2);
		void setAsciiStream(java.lang.String arg0, java.io.InputStream arg1, long arg2);
		void setAsciiStream(java.lang.String arg0, java.io.InputStream arg1);
		void setCharacterStream(java.lang.String arg0, java.io.Reader arg1, long arg2);
		void setCharacterStream(java.lang.String arg0, java.io.Reader arg1);
		void setCharacterStream(java.lang.String arg0, java.io.Reader arg1, int arg2);
		void setNString(java.lang.String arg0, java.lang.String arg1);
		void setNCharacterStream(java.lang.String arg0, java.io.Reader arg1);
		void setNCharacterStream(java.lang.String arg0, java.io.Reader arg1, long arg2);
		void setNClob(java.lang.String arg0, java.io.Reader arg1, long arg2);
		void setNClob(java.lang.String arg0, java.io.Reader arg1);
		void setClob(java.lang.String arg0, java.io.Reader arg1, long arg2);
		void setClob(java.lang.String arg0, java.io.Reader arg1);
		void setClob(java.lang.String arg0, java.sql.Clob arg1);
		void setBlob(java.lang.String arg0, java.io.InputStream arg1, long arg2);
		void setBlob(java.lang.String arg0, java.sql.Blob arg1);
		void setBlob(java.lang.String arg0, java.io.InputStream arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.CallableStatement))]
	public sealed partial class CallableStatement_ : java.lang.Object, CallableStatement
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CallableStatement_()
		{
			InitJNI();
		}
		internal CallableStatement_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getObject23994;
		 global::java.lang.Object java.sql.CallableStatement.getObject(int arg0, java.util.Map arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getObject23994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getObject23994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getObject23995;
		 global::java.lang.Object java.sql.CallableStatement.getObject(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getObject23995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getObject23995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getObject23996;
		 global::java.lang.Object java.sql.CallableStatement.getObject(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getObject23996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getObject23996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getObject23997;
		 global::java.lang.Object java.sql.CallableStatement.getObject(java.lang.String arg0, java.util.Map arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getObject23997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getObject23997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean23998;
		 bool java.sql.CallableStatement.getBoolean(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._getBoolean23998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getBoolean23998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean23999;
		 bool java.sql.CallableStatement.getBoolean(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._getBoolean23999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getBoolean23999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getByte24000;
		 byte java.sql.CallableStatement.getByte(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.sql.CallableStatement_._getByte24000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getByte24000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getByte24001;
		 byte java.sql.CallableStatement.getByte(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.sql.CallableStatement_._getByte24001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getByte24001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShort24002;
		 short java.sql.CallableStatement.getShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.sql.CallableStatement_._getShort24002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getShort24002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShort24003;
		 short java.sql.CallableStatement.getShort(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.sql.CallableStatement_._getShort24003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getShort24003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt24004;
		 int java.sql.CallableStatement.getInt(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._getInt24004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getInt24004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt24005;
		 int java.sql.CallableStatement.getInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._getInt24005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getInt24005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong24006;
		 long java.sql.CallableStatement.getLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.sql.CallableStatement_._getLong24006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getLong24006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong24007;
		 long java.sql.CallableStatement.getLong(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.sql.CallableStatement_._getLong24007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getLong24007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat24008;
		 float java.sql.CallableStatement.getFloat(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.sql.CallableStatement_._getFloat24008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getFloat24008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat24009;
		 float java.sql.CallableStatement.getFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.sql.CallableStatement_._getFloat24009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getFloat24009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble24010;
		 double java.sql.CallableStatement.getDouble(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.sql.CallableStatement_._getDouble24010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getDouble24010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble24011;
		 double java.sql.CallableStatement.getDouble(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.sql.CallableStatement_._getDouble24011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getDouble24011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBytes24012;
		 byte[] java.sql.CallableStatement.getBytes(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getBytes24012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getBytes24012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getBytes24013;
		 byte[] java.sql.CallableStatement.getBytes(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getBytes24013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getBytes24013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getArray24014;
		 global::java.sql.Array java.sql.CallableStatement.getArray(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getArray24014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Array;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getArray24014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Array;
		}
		internal static global::MonoJavaBridge.MethodId _getArray24015;
		 global::java.sql.Array java.sql.CallableStatement.getArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getArray24015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Array;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getArray24015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Array;
		}
		internal static global::MonoJavaBridge.MethodId _getURL24016;
		 global::java.net.URL java.sql.CallableStatement.getURL(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getURL24016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getURL24016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _getURL24017;
		 global::java.net.URL java.sql.CallableStatement.getURL(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getURL24017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.net.URL>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getURL24017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _setBoolean24018;
		 void java.sql.CallableStatement.setBoolean(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBoolean24018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBoolean24018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setByte24019;
		 void java.sql.CallableStatement.setByte(java.lang.String arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setByte24019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setByte24019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setShort24020;
		 void java.sql.CallableStatement.setShort(java.lang.String arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setShort24020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setShort24020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setInt24021;
		 void java.sql.CallableStatement.setInt(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setInt24021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setInt24021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLong24022;
		 void java.sql.CallableStatement.setLong(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setLong24022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setLong24022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFloat24023;
		 void java.sql.CallableStatement.setFloat(java.lang.String arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setFloat24023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setFloat24023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDouble24024;
		 void java.sql.CallableStatement.setDouble(java.lang.String arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setDouble24024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setDouble24024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTimestamp24025;
		 void java.sql.CallableStatement.setTimestamp(java.lang.String arg0, java.sql.Timestamp arg1, java.util.Calendar arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setTimestamp24025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setTimestamp24025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setTimestamp24026;
		 void java.sql.CallableStatement.setTimestamp(java.lang.String arg0, java.sql.Timestamp arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setTimestamp24026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setTimestamp24026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getRef24027;
		 global::java.sql.Ref java.sql.CallableStatement.getRef(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Ref>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getRef24027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Ref;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Ref>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getRef24027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Ref;
		}
		internal static global::MonoJavaBridge.MethodId _getRef24028;
		 global::java.sql.Ref java.sql.CallableStatement.getRef(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Ref>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getRef24028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Ref;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Ref>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getRef24028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Ref;
		}
		internal static global::MonoJavaBridge.MethodId _getString24029;
		 global::java.lang.String java.sql.CallableStatement.getString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getString24029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getString24029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getString24030;
		 global::java.lang.String java.sql.CallableStatement.getString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getString24030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getString24030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setURL24031;
		 void java.sql.CallableStatement.setURL(java.lang.String arg0, java.net.URL arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setURL24031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setURL24031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTime24032;
		 void java.sql.CallableStatement.setTime(java.lang.String arg0, java.sql.Time arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setTime24032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setTime24032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTime24033;
		 void java.sql.CallableStatement.setTime(java.lang.String arg0, java.sql.Time arg1, java.util.Calendar arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setTime24033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setTime24033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getTime24034;
		 global::java.sql.Time java.sql.CallableStatement.getTime(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getTime24034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Time;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getTime24034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _getTime24035;
		 global::java.sql.Time java.sql.CallableStatement.getTime(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getTime24035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Time;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getTime24035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _getTime24036;
		 global::java.sql.Time java.sql.CallableStatement.getTime(java.lang.String arg0, java.util.Calendar arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getTime24036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Time;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getTime24036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _getTime24037;
		 global::java.sql.Time java.sql.CallableStatement.getTime(int arg0, java.util.Calendar arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getTime24037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Time;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getTime24037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _getDate24038;
		 global::java.sql.Date java.sql.CallableStatement.getDate(java.lang.String arg0, java.util.Calendar arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getDate24038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getDate24038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getDate24039;
		 global::java.sql.Date java.sql.CallableStatement.getDate(int arg0, java.util.Calendar arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getDate24039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getDate24039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getDate24040;
		 global::java.sql.Date java.sql.CallableStatement.getDate(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getDate24040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getDate24040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getDate24041;
		 global::java.sql.Date java.sql.CallableStatement.getDate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getDate24041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getDate24041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getTimestamp24042;
		 global::java.sql.Timestamp java.sql.CallableStatement.getTimestamp(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getTimestamp24042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Timestamp;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getTimestamp24042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _getTimestamp24043;
		 global::java.sql.Timestamp java.sql.CallableStatement.getTimestamp(java.lang.String arg0, java.util.Calendar arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getTimestamp24043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Timestamp;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getTimestamp24043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _getTimestamp24044;
		 global::java.sql.Timestamp java.sql.CallableStatement.getTimestamp(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getTimestamp24044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Timestamp;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getTimestamp24044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _getTimestamp24045;
		 global::java.sql.Timestamp java.sql.CallableStatement.getTimestamp(int arg0, java.util.Calendar arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getTimestamp24045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Timestamp;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getTimestamp24045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _setDate24046;
		 void java.sql.CallableStatement.setDate(java.lang.String arg0, java.sql.Date arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setDate24046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setDate24046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDate24047;
		 void java.sql.CallableStatement.setDate(java.lang.String arg0, java.sql.Date arg1, java.util.Calendar arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setDate24047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setDate24047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getBlob24048;
		 global::java.sql.Blob java.sql.CallableStatement.getBlob(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getBlob24048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Blob;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getBlob24048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Blob;
		}
		internal static global::MonoJavaBridge.MethodId _getBlob24049;
		 global::java.sql.Blob java.sql.CallableStatement.getBlob(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getBlob24049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Blob;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getBlob24049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Blob;
		}
		internal static global::MonoJavaBridge.MethodId _setString24050;
		 void java.sql.CallableStatement.setString(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setString24050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setString24050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setObject24051;
		 void java.sql.CallableStatement.setObject(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setObject24051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setObject24051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setObject24052;
		 void java.sql.CallableStatement.setObject(java.lang.String arg0, java.lang.Object arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setObject24052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setObject24052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setObject24053;
		 void java.sql.CallableStatement.setObject(java.lang.String arg0, java.lang.Object arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setObject24053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setObject24053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _wasNull24054;
		 bool java.sql.CallableStatement.wasNull() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._wasNull24054);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._wasNull24054);
		}
		internal static global::MonoJavaBridge.MethodId _getBigDecimal24055;
		 global::java.math.BigDecimal java.sql.CallableStatement.getBigDecimal(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getBigDecimal24055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getBigDecimal24055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _getBigDecimal24056;
		 global::java.math.BigDecimal java.sql.CallableStatement.getBigDecimal(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getBigDecimal24056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getBigDecimal24056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _getBigDecimal24057;
		 global::java.math.BigDecimal java.sql.CallableStatement.getBigDecimal(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getBigDecimal24057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getBigDecimal24057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterStream24058;
		 global::java.io.Reader java.sql.CallableStatement.getCharacterStream(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getCharacterStream24058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getCharacterStream24058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterStream24059;
		 global::java.io.Reader java.sql.CallableStatement.getCharacterStream(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getCharacterStream24059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getCharacterStream24059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _getClob24060;
		 global::java.sql.Clob java.sql.CallableStatement.getClob(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getClob24060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Clob;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getClob24060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Clob;
		}
		internal static global::MonoJavaBridge.MethodId _getClob24061;
		 global::java.sql.Clob java.sql.CallableStatement.getClob(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getClob24061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Clob;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getClob24061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Clob;
		}
		internal static global::MonoJavaBridge.MethodId _getNString24062;
		 global::java.lang.String java.sql.CallableStatement.getNString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getNString24062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getNString24062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNString24063;
		 global::java.lang.String java.sql.CallableStatement.getNString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getNString24063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getNString24063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNCharacterStream24064;
		 global::java.io.Reader java.sql.CallableStatement.getNCharacterStream(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getNCharacterStream24064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getNCharacterStream24064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _getNCharacterStream24065;
		 global::java.io.Reader java.sql.CallableStatement.getNCharacterStream(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getNCharacterStream24065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getNCharacterStream24065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _setBytes24066;
		 void java.sql.CallableStatement.setBytes(java.lang.String arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBytes24066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBytes24066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream24067;
		 void java.sql.CallableStatement.setBinaryStream(java.lang.String arg0, java.io.InputStream arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBinaryStream24067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBinaryStream24067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream24068;
		 void java.sql.CallableStatement.setBinaryStream(java.lang.String arg0, java.io.InputStream arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBinaryStream24068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBinaryStream24068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream24069;
		 void java.sql.CallableStatement.setBinaryStream(java.lang.String arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBinaryStream24069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBinaryStream24069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _registerOutParameter24070;
		 void java.sql.CallableStatement.registerOutParameter(int arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._registerOutParameter24070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._registerOutParameter24070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _registerOutParameter24071;
		 void java.sql.CallableStatement.registerOutParameter(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._registerOutParameter24071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._registerOutParameter24071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _registerOutParameter24072;
		 void java.sql.CallableStatement.registerOutParameter(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._registerOutParameter24072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._registerOutParameter24072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _registerOutParameter24073;
		 void java.sql.CallableStatement.registerOutParameter(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._registerOutParameter24073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._registerOutParameter24073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _registerOutParameter24074;
		 void java.sql.CallableStatement.registerOutParameter(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._registerOutParameter24074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._registerOutParameter24074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _registerOutParameter24075;
		 void java.sql.CallableStatement.registerOutParameter(java.lang.String arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._registerOutParameter24075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._registerOutParameter24075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNull24076;
		 void java.sql.CallableStatement.setNull(java.lang.String arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNull24076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNull24076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNull24077;
		 void java.sql.CallableStatement.setNull(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNull24077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNull24077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBigDecimal24078;
		 void java.sql.CallableStatement.setBigDecimal(java.lang.String arg0, java.math.BigDecimal arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBigDecimal24078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBigDecimal24078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream24079;
		 void java.sql.CallableStatement.setAsciiStream(java.lang.String arg0, java.io.InputStream arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setAsciiStream24079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setAsciiStream24079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream24080;
		 void java.sql.CallableStatement.setAsciiStream(java.lang.String arg0, java.io.InputStream arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setAsciiStream24080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setAsciiStream24080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream24081;
		 void java.sql.CallableStatement.setAsciiStream(java.lang.String arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setAsciiStream24081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setAsciiStream24081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream24082;
		 void java.sql.CallableStatement.setCharacterStream(java.lang.String arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setCharacterStream24082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setCharacterStream24082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream24083;
		 void java.sql.CallableStatement.setCharacterStream(java.lang.String arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setCharacterStream24083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setCharacterStream24083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream24084;
		 void java.sql.CallableStatement.setCharacterStream(java.lang.String arg0, java.io.Reader arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setCharacterStream24084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setCharacterStream24084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNString24085;
		 void java.sql.CallableStatement.setNString(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNString24085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNString24085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNCharacterStream24086;
		 void java.sql.CallableStatement.setNCharacterStream(java.lang.String arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNCharacterStream24086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNCharacterStream24086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNCharacterStream24087;
		 void java.sql.CallableStatement.setNCharacterStream(java.lang.String arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNCharacterStream24087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNCharacterStream24087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNClob24088;
		 void java.sql.CallableStatement.setNClob(java.lang.String arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNClob24088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNClob24088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNClob24089;
		 void java.sql.CallableStatement.setNClob(java.lang.String arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNClob24089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNClob24089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setClob24090;
		 void java.sql.CallableStatement.setClob(java.lang.String arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setClob24090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setClob24090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setClob24091;
		 void java.sql.CallableStatement.setClob(java.lang.String arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setClob24091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setClob24091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setClob24092;
		 void java.sql.CallableStatement.setClob(java.lang.String arg0, java.sql.Clob arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setClob24092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setClob24092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob24093;
		 void java.sql.CallableStatement.setBlob(java.lang.String arg0, java.io.InputStream arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBlob24093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBlob24093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob24094;
		 void java.sql.CallableStatement.setBlob(java.lang.String arg0, java.sql.Blob arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBlob24094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBlob24094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob24095;
		 void java.sql.CallableStatement.setBlob(java.lang.String arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBlob24095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBlob24095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBoolean24096;
		 void java.sql.PreparedStatement.setBoolean(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBoolean24096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBoolean24096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setByte24097;
		 void java.sql.PreparedStatement.setByte(int arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setByte24097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setByte24097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setShort24098;
		 void java.sql.PreparedStatement.setShort(int arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setShort24098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setShort24098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setInt24099;
		 void java.sql.PreparedStatement.setInt(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setInt24099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setInt24099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLong24100;
		 void java.sql.PreparedStatement.setLong(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setLong24100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setLong24100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFloat24101;
		 void java.sql.PreparedStatement.setFloat(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setFloat24101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setFloat24101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDouble24102;
		 void java.sql.PreparedStatement.setDouble(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setDouble24102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setDouble24102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTimestamp24103;
		 void java.sql.PreparedStatement.setTimestamp(int arg0, java.sql.Timestamp arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setTimestamp24103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setTimestamp24103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTimestamp24104;
		 void java.sql.PreparedStatement.setTimestamp(int arg0, java.sql.Timestamp arg1, java.util.Calendar arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setTimestamp24104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setTimestamp24104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setURL24105;
		 void java.sql.PreparedStatement.setURL(int arg0, java.net.URL arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setURL24105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setURL24105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTime24106;
		 void java.sql.PreparedStatement.setTime(int arg0, java.sql.Time arg1, java.util.Calendar arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setTime24106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setTime24106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setTime24107;
		 void java.sql.PreparedStatement.setTime(int arg0, java.sql.Time arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setTime24107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setTime24107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDate24108;
		 void java.sql.PreparedStatement.setDate(int arg0, java.sql.Date arg1, java.util.Calendar arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setDate24108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setDate24108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setDate24109;
		 void java.sql.PreparedStatement.setDate(int arg0, java.sql.Date arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setDate24109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setDate24109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _execute24110;
		 bool java.sql.PreparedStatement.execute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._execute24110);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._execute24110);
		}
		internal static global::MonoJavaBridge.MethodId _addBatch24111;
		 void java.sql.PreparedStatement.addBatch() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._addBatch24111);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._addBatch24111);
		}
		internal static global::MonoJavaBridge.MethodId _setString24112;
		 void java.sql.PreparedStatement.setString(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setString24112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setString24112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setObject24113;
		 void java.sql.PreparedStatement.setObject(int arg0, java.lang.Object arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setObject24113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setObject24113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setObject24114;
		 void java.sql.PreparedStatement.setObject(int arg0, java.lang.Object arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setObject24114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setObject24114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setObject24115;
		 void java.sql.PreparedStatement.setObject(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setObject24115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setObject24115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMetaData24116;
		 global::java.sql.ResultSetMetaData java.sql.PreparedStatement.getMetaData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSetMetaData>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getMetaData24116)) as java.sql.ResultSetMetaData;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSetMetaData>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getMetaData24116)) as java.sql.ResultSetMetaData;
		}
		internal static global::MonoJavaBridge.MethodId _setBytes24117;
		 void java.sql.PreparedStatement.setBytes(int arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBytes24117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBytes24117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream24118;
		 void java.sql.PreparedStatement.setBinaryStream(int arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBinaryStream24118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBinaryStream24118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream24119;
		 void java.sql.PreparedStatement.setBinaryStream(int arg0, java.io.InputStream arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBinaryStream24119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBinaryStream24119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream24120;
		 void java.sql.PreparedStatement.setBinaryStream(int arg0, java.io.InputStream arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBinaryStream24120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBinaryStream24120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNull24121;
		 void java.sql.PreparedStatement.setNull(int arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNull24121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNull24121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNull24122;
		 void java.sql.PreparedStatement.setNull(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNull24122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNull24122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBigDecimal24123;
		 void java.sql.PreparedStatement.setBigDecimal(int arg0, java.math.BigDecimal arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBigDecimal24123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBigDecimal24123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream24124;
		 void java.sql.PreparedStatement.setAsciiStream(int arg0, java.io.InputStream arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setAsciiStream24124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setAsciiStream24124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream24125;
		 void java.sql.PreparedStatement.setAsciiStream(int arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setAsciiStream24125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setAsciiStream24125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream24126;
		 void java.sql.PreparedStatement.setAsciiStream(int arg0, java.io.InputStream arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setAsciiStream24126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setAsciiStream24126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream24127;
		 void java.sql.PreparedStatement.setCharacterStream(int arg0, java.io.Reader arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setCharacterStream24127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setCharacterStream24127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream24128;
		 void java.sql.PreparedStatement.setCharacterStream(int arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setCharacterStream24128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setCharacterStream24128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream24129;
		 void java.sql.PreparedStatement.setCharacterStream(int arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setCharacterStream24129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setCharacterStream24129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNString24130;
		 void java.sql.PreparedStatement.setNString(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNString24130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNString24130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNCharacterStream24131;
		 void java.sql.PreparedStatement.setNCharacterStream(int arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNCharacterStream24131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNCharacterStream24131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNCharacterStream24132;
		 void java.sql.PreparedStatement.setNCharacterStream(int arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNCharacterStream24132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNCharacterStream24132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNClob24133;
		 void java.sql.PreparedStatement.setNClob(int arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNClob24133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNClob24133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNClob24134;
		 void java.sql.PreparedStatement.setNClob(int arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNClob24134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNClob24134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setClob24135;
		 void java.sql.PreparedStatement.setClob(int arg0, java.sql.Clob arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setClob24135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setClob24135, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setClob24136;
		 void java.sql.PreparedStatement.setClob(int arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setClob24136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setClob24136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setClob24137;
		 void java.sql.PreparedStatement.setClob(int arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setClob24137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setClob24137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob24138;
		 void java.sql.PreparedStatement.setBlob(int arg0, java.sql.Blob arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBlob24138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBlob24138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob24139;
		 void java.sql.PreparedStatement.setBlob(int arg0, java.io.InputStream arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBlob24139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBlob24139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob24140;
		 void java.sql.PreparedStatement.setBlob(int arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBlob24140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBlob24140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _executeQuery24141;
		 global::java.sql.ResultSet java.sql.PreparedStatement.executeQuery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._executeQuery24141)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._executeQuery24141)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate24142;
		 int java.sql.PreparedStatement.executeUpdate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._executeUpdate24142);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._executeUpdate24142);
		}
		internal static global::MonoJavaBridge.MethodId _setUnicodeStream24143;
		 void java.sql.PreparedStatement.setUnicodeStream(int arg0, java.io.InputStream arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setUnicodeStream24143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setUnicodeStream24143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _clearParameters24144;
		 void java.sql.PreparedStatement.clearParameters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._clearParameters24144);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._clearParameters24144);
		}
		internal static global::MonoJavaBridge.MethodId _setRef24145;
		 void java.sql.PreparedStatement.setRef(int arg0, java.sql.Ref arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setRef24145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setRef24145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setArray24146;
		 void java.sql.PreparedStatement.setArray(int arg0, java.sql.Array arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setArray24146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setArray24146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getParameterMetaData24147;
		 global::java.sql.ParameterMetaData java.sql.PreparedStatement.getParameterMetaData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ParameterMetaData>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getParameterMetaData24147)) as java.sql.ParameterMetaData;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ParameterMetaData>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getParameterMetaData24147)) as java.sql.ParameterMetaData;
		}
		internal static global::MonoJavaBridge.MethodId _close24148;
		 void java.sql.Statement.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._close24148);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._close24148);
		}
		internal static global::MonoJavaBridge.MethodId _isClosed24149;
		 bool java.sql.Statement.isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._isClosed24149);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._isClosed24149);
		}
		internal static global::MonoJavaBridge.MethodId _execute24150;
		 bool java.sql.Statement.execute(java.lang.String arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._execute24150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._execute24150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _execute24151;
		 bool java.sql.Statement.execute(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._execute24151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._execute24151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _execute24152;
		 bool java.sql.Statement.execute(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._execute24152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._execute24152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _execute24153;
		 bool java.sql.Statement.execute(java.lang.String arg0, java.lang.String[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._execute24153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._execute24153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _cancel24154;
		 void java.sql.Statement.cancel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._cancel24154);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._cancel24154);
		}
		internal static global::MonoJavaBridge.MethodId _addBatch24155;
		 void java.sql.Statement.addBatch(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._addBatch24155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._addBatch24155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getConnection24156;
		 global::java.sql.Connection java.sql.Statement.getConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getConnection24156)) as java.sql.Connection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getConnection24156)) as java.sql.Connection;
		}
		internal static global::MonoJavaBridge.MethodId _getResultSet24157;
		 global::java.sql.ResultSet java.sql.Statement.getResultSet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getResultSet24157)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getResultSet24157)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getWarnings24158;
		 global::java.sql.SQLWarning java.sql.Statement.getWarnings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getWarnings24158)) as java.sql.SQLWarning;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getWarnings24158)) as java.sql.SQLWarning;
		}
		internal static global::MonoJavaBridge.MethodId _clearWarnings24159;
		 void java.sql.Statement.clearWarnings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._clearWarnings24159);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._clearWarnings24159);
		}
		internal static global::MonoJavaBridge.MethodId _setFetchDirection24160;
		 void java.sql.Statement.setFetchDirection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setFetchDirection24160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setFetchDirection24160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFetchDirection24161;
		 int java.sql.Statement.getFetchDirection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._getFetchDirection24161);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getFetchDirection24161);
		}
		internal static global::MonoJavaBridge.MethodId _setFetchSize24162;
		 void java.sql.Statement.setFetchSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setFetchSize24162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setFetchSize24162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFetchSize24163;
		 int java.sql.Statement.getFetchSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._getFetchSize24163);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getFetchSize24163);
		}
		internal static global::MonoJavaBridge.MethodId _executeQuery24164;
		 global::java.sql.ResultSet java.sql.Statement.executeQuery(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._executeQuery24164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._executeQuery24164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate24165;
		 int java.sql.Statement.executeUpdate(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._executeUpdate24165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._executeUpdate24165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate24166;
		 int java.sql.Statement.executeUpdate(java.lang.String arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._executeUpdate24166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._executeUpdate24166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate24167;
		 int java.sql.Statement.executeUpdate(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._executeUpdate24167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._executeUpdate24167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate24168;
		 int java.sql.Statement.executeUpdate(java.lang.String arg0, java.lang.String[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._executeUpdate24168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._executeUpdate24168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxFieldSize24169;
		 int java.sql.Statement.getMaxFieldSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._getMaxFieldSize24169);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getMaxFieldSize24169);
		}
		internal static global::MonoJavaBridge.MethodId _setMaxFieldSize24170;
		 void java.sql.Statement.setMaxFieldSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setMaxFieldSize24170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setMaxFieldSize24170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxRows24171;
		 int java.sql.Statement.getMaxRows() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._getMaxRows24171);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getMaxRows24171);
		}
		internal static global::MonoJavaBridge.MethodId _setMaxRows24172;
		 void java.sql.Statement.setMaxRows(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setMaxRows24172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setMaxRows24172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEscapeProcessing24173;
		 void java.sql.Statement.setEscapeProcessing(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setEscapeProcessing24173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setEscapeProcessing24173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getQueryTimeout24174;
		 int java.sql.Statement.getQueryTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._getQueryTimeout24174);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getQueryTimeout24174);
		}
		internal static global::MonoJavaBridge.MethodId _setQueryTimeout24175;
		 void java.sql.Statement.setQueryTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setQueryTimeout24175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setQueryTimeout24175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCursorName24176;
		 void java.sql.Statement.setCursorName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setCursorName24176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setCursorName24176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUpdateCount24177;
		 int java.sql.Statement.getUpdateCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._getUpdateCount24177);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getUpdateCount24177);
		}
		internal static global::MonoJavaBridge.MethodId _getMoreResults24178;
		 bool java.sql.Statement.getMoreResults() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._getMoreResults24178);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getMoreResults24178);
		}
		internal static global::MonoJavaBridge.MethodId _getMoreResults24179;
		 bool java.sql.Statement.getMoreResults(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._getMoreResults24179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getMoreResults24179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getResultSetConcurrency24180;
		 int java.sql.Statement.getResultSetConcurrency() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._getResultSetConcurrency24180);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getResultSetConcurrency24180);
		}
		internal static global::MonoJavaBridge.MethodId _getResultSetType24181;
		 int java.sql.Statement.getResultSetType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._getResultSetType24181);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getResultSetType24181);
		}
		internal static global::MonoJavaBridge.MethodId _clearBatch24182;
		 void java.sql.Statement.clearBatch() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._clearBatch24182);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._clearBatch24182);
		}
		internal static global::MonoJavaBridge.MethodId _executeBatch24183;
		 int[] java.sql.Statement.executeBatch() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._executeBatch24183)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._executeBatch24183)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _getGeneratedKeys24184;
		 global::java.sql.ResultSet java.sql.Statement.getGeneratedKeys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getGeneratedKeys24184)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getGeneratedKeys24184)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getResultSetHoldability24185;
		 int java.sql.Statement.getResultSetHoldability() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._getResultSetHoldability24185);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getResultSetHoldability24185);
		}
		internal static global::MonoJavaBridge.MethodId _setPoolable24186;
		 void java.sql.Statement.setPoolable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setPoolable24186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setPoolable24186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPoolable24187;
		 bool java.sql.Statement.isPoolable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._isPoolable24187);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._isPoolable24187);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.CallableStatement_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/CallableStatement"));
			global::java.sql.CallableStatement_._getObject23994 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getObject", "(ILjava/util/Map;)Ljava/lang/Object;");
			global::java.sql.CallableStatement_._getObject23995 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getObject", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::java.sql.CallableStatement_._getObject23996 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getObject", "(I)Ljava/lang/Object;");
			global::java.sql.CallableStatement_._getObject23997 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getObject", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/Object;");
			global::java.sql.CallableStatement_._getBoolean23998 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getBoolean", "(I)Z");
			global::java.sql.CallableStatement_._getBoolean23999 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getBoolean", "(Ljava/lang/String;)Z");
			global::java.sql.CallableStatement_._getByte24000 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getByte", "(I)B");
			global::java.sql.CallableStatement_._getByte24001 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getByte", "(Ljava/lang/String;)B");
			global::java.sql.CallableStatement_._getShort24002 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getShort", "(I)S");
			global::java.sql.CallableStatement_._getShort24003 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getShort", "(Ljava/lang/String;)S");
			global::java.sql.CallableStatement_._getInt24004 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getInt", "(Ljava/lang/String;)I");
			global::java.sql.CallableStatement_._getInt24005 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getInt", "(I)I");
			global::java.sql.CallableStatement_._getLong24006 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getLong", "(I)J");
			global::java.sql.CallableStatement_._getLong24007 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getLong", "(Ljava/lang/String;)J");
			global::java.sql.CallableStatement_._getFloat24008 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getFloat", "(Ljava/lang/String;)F");
			global::java.sql.CallableStatement_._getFloat24009 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getFloat", "(I)F");
			global::java.sql.CallableStatement_._getDouble24010 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getDouble", "(Ljava/lang/String;)D");
			global::java.sql.CallableStatement_._getDouble24011 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getDouble", "(I)D");
			global::java.sql.CallableStatement_._getBytes24012 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getBytes", "(I)[B");
			global::java.sql.CallableStatement_._getBytes24013 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getBytes", "(Ljava/lang/String;)[B");
			global::java.sql.CallableStatement_._getArray24014 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getArray", "(I)Ljava/sql/Array;");
			global::java.sql.CallableStatement_._getArray24015 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getArray", "(Ljava/lang/String;)Ljava/sql/Array;");
			global::java.sql.CallableStatement_._getURL24016 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getURL", "(I)Ljava/net/URL;");
			global::java.sql.CallableStatement_._getURL24017 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getURL", "(Ljava/lang/String;)Ljava/net/URL;");
			global::java.sql.CallableStatement_._setBoolean24018 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBoolean", "(Ljava/lang/String;Z)V");
			global::java.sql.CallableStatement_._setByte24019 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setByte", "(Ljava/lang/String;B)V");
			global::java.sql.CallableStatement_._setShort24020 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setShort", "(Ljava/lang/String;S)V");
			global::java.sql.CallableStatement_._setInt24021 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setInt", "(Ljava/lang/String;I)V");
			global::java.sql.CallableStatement_._setLong24022 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setLong", "(Ljava/lang/String;J)V");
			global::java.sql.CallableStatement_._setFloat24023 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setFloat", "(Ljava/lang/String;F)V");
			global::java.sql.CallableStatement_._setDouble24024 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setDouble", "(Ljava/lang/String;D)V");
			global::java.sql.CallableStatement_._setTimestamp24025 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;Ljava/util/Calendar;)V");
			global::java.sql.CallableStatement_._setTimestamp24026 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;)V");
			global::java.sql.CallableStatement_._getRef24027 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getRef", "(I)Ljava/sql/Ref;");
			global::java.sql.CallableStatement_._getRef24028 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getRef", "(Ljava/lang/String;)Ljava/sql/Ref;");
			global::java.sql.CallableStatement_._getString24029 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getString", "(I)Ljava/lang/String;");
			global::java.sql.CallableStatement_._getString24030 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.sql.CallableStatement_._setURL24031 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setURL", "(Ljava/lang/String;Ljava/net/URL;)V");
			global::java.sql.CallableStatement_._setTime24032 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setTime", "(Ljava/lang/String;Ljava/sql/Time;)V");
			global::java.sql.CallableStatement_._setTime24033 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setTime", "(Ljava/lang/String;Ljava/sql/Time;Ljava/util/Calendar;)V");
			global::java.sql.CallableStatement_._getTime24034 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getTime", "(I)Ljava/sql/Time;");
			global::java.sql.CallableStatement_._getTime24035 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getTime", "(Ljava/lang/String;)Ljava/sql/Time;");
			global::java.sql.CallableStatement_._getTime24036 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getTime", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Time;");
			global::java.sql.CallableStatement_._getTime24037 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getTime", "(ILjava/util/Calendar;)Ljava/sql/Time;");
			global::java.sql.CallableStatement_._getDate24038 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getDate", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Date;");
			global::java.sql.CallableStatement_._getDate24039 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getDate", "(ILjava/util/Calendar;)Ljava/sql/Date;");
			global::java.sql.CallableStatement_._getDate24040 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getDate", "(Ljava/lang/String;)Ljava/sql/Date;");
			global::java.sql.CallableStatement_._getDate24041 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getDate", "(I)Ljava/sql/Date;");
			global::java.sql.CallableStatement_._getTimestamp24042 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getTimestamp", "(I)Ljava/sql/Timestamp;");
			global::java.sql.CallableStatement_._getTimestamp24043 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getTimestamp", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Timestamp;");
			global::java.sql.CallableStatement_._getTimestamp24044 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getTimestamp", "(Ljava/lang/String;)Ljava/sql/Timestamp;");
			global::java.sql.CallableStatement_._getTimestamp24045 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getTimestamp", "(ILjava/util/Calendar;)Ljava/sql/Timestamp;");
			global::java.sql.CallableStatement_._setDate24046 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setDate", "(Ljava/lang/String;Ljava/sql/Date;)V");
			global::java.sql.CallableStatement_._setDate24047 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setDate", "(Ljava/lang/String;Ljava/sql/Date;Ljava/util/Calendar;)V");
			global::java.sql.CallableStatement_._getBlob24048 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getBlob", "(I)Ljava/sql/Blob;");
			global::java.sql.CallableStatement_._getBlob24049 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getBlob", "(Ljava/lang/String;)Ljava/sql/Blob;");
			global::java.sql.CallableStatement_._setString24050 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setString", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.sql.CallableStatement_._setObject24051 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setObject", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::java.sql.CallableStatement_._setObject24052 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setObject", "(Ljava/lang/String;Ljava/lang/Object;I)V");
			global::java.sql.CallableStatement_._setObject24053 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setObject", "(Ljava/lang/String;Ljava/lang/Object;II)V");
			global::java.sql.CallableStatement_._wasNull24054 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "wasNull", "()Z");
			global::java.sql.CallableStatement_._getBigDecimal24055 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getBigDecimal", "(II)Ljava/math/BigDecimal;");
			global::java.sql.CallableStatement_._getBigDecimal24056 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getBigDecimal", "(Ljava/lang/String;)Ljava/math/BigDecimal;");
			global::java.sql.CallableStatement_._getBigDecimal24057 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getBigDecimal", "(I)Ljava/math/BigDecimal;");
			global::java.sql.CallableStatement_._getCharacterStream24058 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getCharacterStream", "(I)Ljava/io/Reader;");
			global::java.sql.CallableStatement_._getCharacterStream24059 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;");
			global::java.sql.CallableStatement_._getClob24060 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getClob", "(I)Ljava/sql/Clob;");
			global::java.sql.CallableStatement_._getClob24061 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getClob", "(Ljava/lang/String;)Ljava/sql/Clob;");
			global::java.sql.CallableStatement_._getNString24062 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getNString", "(I)Ljava/lang/String;");
			global::java.sql.CallableStatement_._getNString24063 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getNString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.sql.CallableStatement_._getNCharacterStream24064 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getNCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;");
			global::java.sql.CallableStatement_._getNCharacterStream24065 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getNCharacterStream", "(I)Ljava/io/Reader;");
			global::java.sql.CallableStatement_._setBytes24066 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBytes", "(Ljava/lang/String;[B)V");
			global::java.sql.CallableStatement_._setBinaryStream24067 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V");
			global::java.sql.CallableStatement_._setBinaryStream24068 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;J)V");
			global::java.sql.CallableStatement_._setBinaryStream24069 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;)V");
			global::java.sql.CallableStatement_._registerOutParameter24070 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "registerOutParameter", "(IILjava/lang/String;)V");
			global::java.sql.CallableStatement_._registerOutParameter24071 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "registerOutParameter", "(III)V");
			global::java.sql.CallableStatement_._registerOutParameter24072 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "registerOutParameter", "(II)V");
			global::java.sql.CallableStatement_._registerOutParameter24073 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "registerOutParameter", "(Ljava/lang/String;I)V");
			global::java.sql.CallableStatement_._registerOutParameter24074 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "registerOutParameter", "(Ljava/lang/String;II)V");
			global::java.sql.CallableStatement_._registerOutParameter24075 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "registerOutParameter", "(Ljava/lang/String;ILjava/lang/String;)V");
			global::java.sql.CallableStatement_._setNull24076 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNull", "(Ljava/lang/String;ILjava/lang/String;)V");
			global::java.sql.CallableStatement_._setNull24077 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNull", "(Ljava/lang/String;I)V");
			global::java.sql.CallableStatement_._setBigDecimal24078 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBigDecimal", "(Ljava/lang/String;Ljava/math/BigDecimal;)V");
			global::java.sql.CallableStatement_._setAsciiStream24079 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V");
			global::java.sql.CallableStatement_._setAsciiStream24080 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;J)V");
			global::java.sql.CallableStatement_._setAsciiStream24081 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;)V");
			global::java.sql.CallableStatement_._setCharacterStream24082 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::java.sql.CallableStatement_._setCharacterStream24083 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V");
			global::java.sql.CallableStatement_._setCharacterStream24084 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;I)V");
			global::java.sql.CallableStatement_._setNString24085 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNString", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.sql.CallableStatement_._setNCharacterStream24086 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V");
			global::java.sql.CallableStatement_._setNCharacterStream24087 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::java.sql.CallableStatement_._setNClob24088 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNClob", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::java.sql.CallableStatement_._setNClob24089 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNClob", "(Ljava/lang/String;Ljava/io/Reader;)V");
			global::java.sql.CallableStatement_._setClob24090 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setClob", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::java.sql.CallableStatement_._setClob24091 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setClob", "(Ljava/lang/String;Ljava/io/Reader;)V");
			global::java.sql.CallableStatement_._setClob24092 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setClob", "(Ljava/lang/String;Ljava/sql/Clob;)V");
			global::java.sql.CallableStatement_._setBlob24093 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBlob", "(Ljava/lang/String;Ljava/io/InputStream;J)V");
			global::java.sql.CallableStatement_._setBlob24094 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBlob", "(Ljava/lang/String;Ljava/sql/Blob;)V");
			global::java.sql.CallableStatement_._setBlob24095 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBlob", "(Ljava/lang/String;Ljava/io/InputStream;)V");
			global::java.sql.CallableStatement_._setBoolean24096 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBoolean", "(IZ)V");
			global::java.sql.CallableStatement_._setByte24097 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setByte", "(IB)V");
			global::java.sql.CallableStatement_._setShort24098 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setShort", "(IS)V");
			global::java.sql.CallableStatement_._setInt24099 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setInt", "(II)V");
			global::java.sql.CallableStatement_._setLong24100 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setLong", "(IJ)V");
			global::java.sql.CallableStatement_._setFloat24101 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setFloat", "(IF)V");
			global::java.sql.CallableStatement_._setDouble24102 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setDouble", "(ID)V");
			global::java.sql.CallableStatement_._setTimestamp24103 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setTimestamp", "(ILjava/sql/Timestamp;)V");
			global::java.sql.CallableStatement_._setTimestamp24104 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setTimestamp", "(ILjava/sql/Timestamp;Ljava/util/Calendar;)V");
			global::java.sql.CallableStatement_._setURL24105 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setURL", "(ILjava/net/URL;)V");
			global::java.sql.CallableStatement_._setTime24106 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setTime", "(ILjava/sql/Time;Ljava/util/Calendar;)V");
			global::java.sql.CallableStatement_._setTime24107 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setTime", "(ILjava/sql/Time;)V");
			global::java.sql.CallableStatement_._setDate24108 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setDate", "(ILjava/sql/Date;Ljava/util/Calendar;)V");
			global::java.sql.CallableStatement_._setDate24109 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setDate", "(ILjava/sql/Date;)V");
			global::java.sql.CallableStatement_._execute24110 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "execute", "()Z");
			global::java.sql.CallableStatement_._addBatch24111 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "addBatch", "()V");
			global::java.sql.CallableStatement_._setString24112 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setString", "(ILjava/lang/String;)V");
			global::java.sql.CallableStatement_._setObject24113 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setObject", "(ILjava/lang/Object;I)V");
			global::java.sql.CallableStatement_._setObject24114 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setObject", "(ILjava/lang/Object;II)V");
			global::java.sql.CallableStatement_._setObject24115 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setObject", "(ILjava/lang/Object;)V");
			global::java.sql.CallableStatement_._getMetaData24116 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getMetaData", "()Ljava/sql/ResultSetMetaData;");
			global::java.sql.CallableStatement_._setBytes24117 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBytes", "(I[B)V");
			global::java.sql.CallableStatement_._setBinaryStream24118 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBinaryStream", "(ILjava/io/InputStream;)V");
			global::java.sql.CallableStatement_._setBinaryStream24119 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBinaryStream", "(ILjava/io/InputStream;I)V");
			global::java.sql.CallableStatement_._setBinaryStream24120 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBinaryStream", "(ILjava/io/InputStream;J)V");
			global::java.sql.CallableStatement_._setNull24121 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNull", "(IILjava/lang/String;)V");
			global::java.sql.CallableStatement_._setNull24122 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNull", "(II)V");
			global::java.sql.CallableStatement_._setBigDecimal24123 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBigDecimal", "(ILjava/math/BigDecimal;)V");
			global::java.sql.CallableStatement_._setAsciiStream24124 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setAsciiStream", "(ILjava/io/InputStream;I)V");
			global::java.sql.CallableStatement_._setAsciiStream24125 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setAsciiStream", "(ILjava/io/InputStream;)V");
			global::java.sql.CallableStatement_._setAsciiStream24126 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setAsciiStream", "(ILjava/io/InputStream;J)V");
			global::java.sql.CallableStatement_._setCharacterStream24127 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setCharacterStream", "(ILjava/io/Reader;I)V");
			global::java.sql.CallableStatement_._setCharacterStream24128 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setCharacterStream", "(ILjava/io/Reader;J)V");
			global::java.sql.CallableStatement_._setCharacterStream24129 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setCharacterStream", "(ILjava/io/Reader;)V");
			global::java.sql.CallableStatement_._setNString24130 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNString", "(ILjava/lang/String;)V");
			global::java.sql.CallableStatement_._setNCharacterStream24131 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNCharacterStream", "(ILjava/io/Reader;J)V");
			global::java.sql.CallableStatement_._setNCharacterStream24132 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNCharacterStream", "(ILjava/io/Reader;)V");
			global::java.sql.CallableStatement_._setNClob24133 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNClob", "(ILjava/io/Reader;)V");
			global::java.sql.CallableStatement_._setNClob24134 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNClob", "(ILjava/io/Reader;J)V");
			global::java.sql.CallableStatement_._setClob24135 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setClob", "(ILjava/sql/Clob;)V");
			global::java.sql.CallableStatement_._setClob24136 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setClob", "(ILjava/io/Reader;J)V");
			global::java.sql.CallableStatement_._setClob24137 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setClob", "(ILjava/io/Reader;)V");
			global::java.sql.CallableStatement_._setBlob24138 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBlob", "(ILjava/sql/Blob;)V");
			global::java.sql.CallableStatement_._setBlob24139 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBlob", "(ILjava/io/InputStream;J)V");
			global::java.sql.CallableStatement_._setBlob24140 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBlob", "(ILjava/io/InputStream;)V");
			global::java.sql.CallableStatement_._executeQuery24141 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "executeQuery", "()Ljava/sql/ResultSet;");
			global::java.sql.CallableStatement_._executeUpdate24142 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "executeUpdate", "()I");
			global::java.sql.CallableStatement_._setUnicodeStream24143 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setUnicodeStream", "(ILjava/io/InputStream;I)V");
			global::java.sql.CallableStatement_._clearParameters24144 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "clearParameters", "()V");
			global::java.sql.CallableStatement_._setRef24145 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setRef", "(ILjava/sql/Ref;)V");
			global::java.sql.CallableStatement_._setArray24146 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setArray", "(ILjava/sql/Array;)V");
			global::java.sql.CallableStatement_._getParameterMetaData24147 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getParameterMetaData", "()Ljava/sql/ParameterMetaData;");
			global::java.sql.CallableStatement_._close24148 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "close", "()V");
			global::java.sql.CallableStatement_._isClosed24149 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "isClosed", "()Z");
			global::java.sql.CallableStatement_._execute24150 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "execute", "(Ljava/lang/String;[I)Z");
			global::java.sql.CallableStatement_._execute24151 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "execute", "(Ljava/lang/String;I)Z");
			global::java.sql.CallableStatement_._execute24152 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "execute", "(Ljava/lang/String;)Z");
			global::java.sql.CallableStatement_._execute24153 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "execute", "(Ljava/lang/String;[Ljava/lang/String;)Z");
			global::java.sql.CallableStatement_._cancel24154 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "cancel", "()V");
			global::java.sql.CallableStatement_._addBatch24155 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "addBatch", "(Ljava/lang/String;)V");
			global::java.sql.CallableStatement_._getConnection24156 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getConnection", "()Ljava/sql/Connection;");
			global::java.sql.CallableStatement_._getResultSet24157 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getResultSet", "()Ljava/sql/ResultSet;");
			global::java.sql.CallableStatement_._getWarnings24158 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getWarnings", "()Ljava/sql/SQLWarning;");
			global::java.sql.CallableStatement_._clearWarnings24159 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "clearWarnings", "()V");
			global::java.sql.CallableStatement_._setFetchDirection24160 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setFetchDirection", "(I)V");
			global::java.sql.CallableStatement_._getFetchDirection24161 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getFetchDirection", "()I");
			global::java.sql.CallableStatement_._setFetchSize24162 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setFetchSize", "(I)V");
			global::java.sql.CallableStatement_._getFetchSize24163 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getFetchSize", "()I");
			global::java.sql.CallableStatement_._executeQuery24164 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "executeQuery", "(Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.CallableStatement_._executeUpdate24165 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "executeUpdate", "(Ljava/lang/String;I)I");
			global::java.sql.CallableStatement_._executeUpdate24166 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "executeUpdate", "(Ljava/lang/String;[I)I");
			global::java.sql.CallableStatement_._executeUpdate24167 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "executeUpdate", "(Ljava/lang/String;)I");
			global::java.sql.CallableStatement_._executeUpdate24168 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "executeUpdate", "(Ljava/lang/String;[Ljava/lang/String;)I");
			global::java.sql.CallableStatement_._getMaxFieldSize24169 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getMaxFieldSize", "()I");
			global::java.sql.CallableStatement_._setMaxFieldSize24170 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setMaxFieldSize", "(I)V");
			global::java.sql.CallableStatement_._getMaxRows24171 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getMaxRows", "()I");
			global::java.sql.CallableStatement_._setMaxRows24172 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setMaxRows", "(I)V");
			global::java.sql.CallableStatement_._setEscapeProcessing24173 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setEscapeProcessing", "(Z)V");
			global::java.sql.CallableStatement_._getQueryTimeout24174 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getQueryTimeout", "()I");
			global::java.sql.CallableStatement_._setQueryTimeout24175 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setQueryTimeout", "(I)V");
			global::java.sql.CallableStatement_._setCursorName24176 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setCursorName", "(Ljava/lang/String;)V");
			global::java.sql.CallableStatement_._getUpdateCount24177 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getUpdateCount", "()I");
			global::java.sql.CallableStatement_._getMoreResults24178 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getMoreResults", "()Z");
			global::java.sql.CallableStatement_._getMoreResults24179 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getMoreResults", "(I)Z");
			global::java.sql.CallableStatement_._getResultSetConcurrency24180 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getResultSetConcurrency", "()I");
			global::java.sql.CallableStatement_._getResultSetType24181 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getResultSetType", "()I");
			global::java.sql.CallableStatement_._clearBatch24182 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "clearBatch", "()V");
			global::java.sql.CallableStatement_._executeBatch24183 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "executeBatch", "()[I");
			global::java.sql.CallableStatement_._getGeneratedKeys24184 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getGeneratedKeys", "()Ljava/sql/ResultSet;");
			global::java.sql.CallableStatement_._getResultSetHoldability24185 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getResultSetHoldability", "()I");
			global::java.sql.CallableStatement_._setPoolable24186 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setPoolable", "(Z)V");
			global::java.sql.CallableStatement_._isPoolable24187 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "isPoolable", "()Z");
		}
	}
}
