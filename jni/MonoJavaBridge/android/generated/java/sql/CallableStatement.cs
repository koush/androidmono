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
		internal static global::MonoJavaBridge.MethodId _getObject18385;
		 global::java.lang.Object java.sql.CallableStatement.getObject(int arg0, java.util.Map arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getObject18385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getObject18385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getObject18386;
		 global::java.lang.Object java.sql.CallableStatement.getObject(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getObject18386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getObject18386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getObject18387;
		 global::java.lang.Object java.sql.CallableStatement.getObject(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getObject18387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getObject18387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getObject18388;
		 global::java.lang.Object java.sql.CallableStatement.getObject(java.lang.String arg0, java.util.Map arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getObject18388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getObject18388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean18389;
		 bool java.sql.CallableStatement.getBoolean(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._getBoolean18389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getBoolean18389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean18390;
		 bool java.sql.CallableStatement.getBoolean(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._getBoolean18390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getBoolean18390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getByte18391;
		 byte java.sql.CallableStatement.getByte(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.sql.CallableStatement_._getByte18391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getByte18391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getByte18392;
		 byte java.sql.CallableStatement.getByte(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.sql.CallableStatement_._getByte18392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getByte18392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShort18393;
		 short java.sql.CallableStatement.getShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.sql.CallableStatement_._getShort18393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getShort18393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShort18394;
		 short java.sql.CallableStatement.getShort(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.sql.CallableStatement_._getShort18394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getShort18394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt18395;
		 int java.sql.CallableStatement.getInt(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._getInt18395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getInt18395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt18396;
		 int java.sql.CallableStatement.getInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._getInt18396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getInt18396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong18397;
		 long java.sql.CallableStatement.getLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.sql.CallableStatement_._getLong18397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getLong18397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong18398;
		 long java.sql.CallableStatement.getLong(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.sql.CallableStatement_._getLong18398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getLong18398, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat18399;
		 float java.sql.CallableStatement.getFloat(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.sql.CallableStatement_._getFloat18399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getFloat18399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat18400;
		 float java.sql.CallableStatement.getFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.sql.CallableStatement_._getFloat18400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getFloat18400, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble18401;
		 double java.sql.CallableStatement.getDouble(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.sql.CallableStatement_._getDouble18401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getDouble18401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble18402;
		 double java.sql.CallableStatement.getDouble(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.sql.CallableStatement_._getDouble18402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getDouble18402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBytes18403;
		 byte[] java.sql.CallableStatement.getBytes(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getBytes18403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getBytes18403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getBytes18404;
		 byte[] java.sql.CallableStatement.getBytes(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getBytes18404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getBytes18404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getArray18405;
		 global::java.sql.Array java.sql.CallableStatement.getArray(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getArray18405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Array;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getArray18405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Array;
		}
		internal static global::MonoJavaBridge.MethodId _getArray18406;
		 global::java.sql.Array java.sql.CallableStatement.getArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getArray18406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Array;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getArray18406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Array;
		}
		internal static global::MonoJavaBridge.MethodId _getURL18407;
		 global::java.net.URL java.sql.CallableStatement.getURL(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getURL18407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getURL18407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _getURL18408;
		 global::java.net.URL java.sql.CallableStatement.getURL(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getURL18408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getURL18408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _setBoolean18409;
		 void java.sql.CallableStatement.setBoolean(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBoolean18409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBoolean18409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setByte18410;
		 void java.sql.CallableStatement.setByte(java.lang.String arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setByte18410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setByte18410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setShort18411;
		 void java.sql.CallableStatement.setShort(java.lang.String arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setShort18411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setShort18411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setInt18412;
		 void java.sql.CallableStatement.setInt(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setInt18412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setInt18412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLong18413;
		 void java.sql.CallableStatement.setLong(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setLong18413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setLong18413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFloat18414;
		 void java.sql.CallableStatement.setFloat(java.lang.String arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setFloat18414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setFloat18414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDouble18415;
		 void java.sql.CallableStatement.setDouble(java.lang.String arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setDouble18415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setDouble18415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTimestamp18416;
		 void java.sql.CallableStatement.setTimestamp(java.lang.String arg0, java.sql.Timestamp arg1, java.util.Calendar arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setTimestamp18416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setTimestamp18416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setTimestamp18417;
		 void java.sql.CallableStatement.setTimestamp(java.lang.String arg0, java.sql.Timestamp arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setTimestamp18417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setTimestamp18417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getRef18418;
		 global::java.sql.Ref java.sql.CallableStatement.getRef(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Ref>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getRef18418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Ref;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Ref>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getRef18418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Ref;
		}
		internal static global::MonoJavaBridge.MethodId _getRef18419;
		 global::java.sql.Ref java.sql.CallableStatement.getRef(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Ref>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getRef18419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Ref;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Ref>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getRef18419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Ref;
		}
		internal static global::MonoJavaBridge.MethodId _getString18420;
		 global::java.lang.String java.sql.CallableStatement.getString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getString18420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getString18420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getString18421;
		 global::java.lang.String java.sql.CallableStatement.getString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getString18421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getString18421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setURL18422;
		 void java.sql.CallableStatement.setURL(java.lang.String arg0, java.net.URL arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setURL18422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setURL18422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTime18423;
		 void java.sql.CallableStatement.setTime(java.lang.String arg0, java.sql.Time arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setTime18423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setTime18423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTime18424;
		 void java.sql.CallableStatement.setTime(java.lang.String arg0, java.sql.Time arg1, java.util.Calendar arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setTime18424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setTime18424, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getTime18425;
		 global::java.sql.Time java.sql.CallableStatement.getTime(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getTime18425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Time;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getTime18425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _getTime18426;
		 global::java.sql.Time java.sql.CallableStatement.getTime(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getTime18426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Time;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getTime18426, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _getTime18427;
		 global::java.sql.Time java.sql.CallableStatement.getTime(java.lang.String arg0, java.util.Calendar arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getTime18427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Time;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getTime18427, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _getTime18428;
		 global::java.sql.Time java.sql.CallableStatement.getTime(int arg0, java.util.Calendar arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getTime18428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Time;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getTime18428, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _getDate18429;
		 global::java.sql.Date java.sql.CallableStatement.getDate(java.lang.String arg0, java.util.Calendar arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getDate18429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getDate18429, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getDate18430;
		 global::java.sql.Date java.sql.CallableStatement.getDate(int arg0, java.util.Calendar arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getDate18430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getDate18430, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getDate18431;
		 global::java.sql.Date java.sql.CallableStatement.getDate(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getDate18431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getDate18431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getDate18432;
		 global::java.sql.Date java.sql.CallableStatement.getDate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getDate18432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getDate18432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getTimestamp18433;
		 global::java.sql.Timestamp java.sql.CallableStatement.getTimestamp(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getTimestamp18433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Timestamp;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getTimestamp18433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _getTimestamp18434;
		 global::java.sql.Timestamp java.sql.CallableStatement.getTimestamp(java.lang.String arg0, java.util.Calendar arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getTimestamp18434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Timestamp;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getTimestamp18434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _getTimestamp18435;
		 global::java.sql.Timestamp java.sql.CallableStatement.getTimestamp(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getTimestamp18435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Timestamp;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getTimestamp18435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _getTimestamp18436;
		 global::java.sql.Timestamp java.sql.CallableStatement.getTimestamp(int arg0, java.util.Calendar arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getTimestamp18436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Timestamp;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getTimestamp18436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _setDate18437;
		 void java.sql.CallableStatement.setDate(java.lang.String arg0, java.sql.Date arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setDate18437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setDate18437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDate18438;
		 void java.sql.CallableStatement.setDate(java.lang.String arg0, java.sql.Date arg1, java.util.Calendar arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setDate18438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setDate18438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getBlob18439;
		 global::java.sql.Blob java.sql.CallableStatement.getBlob(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getBlob18439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Blob;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getBlob18439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Blob;
		}
		internal static global::MonoJavaBridge.MethodId _getBlob18440;
		 global::java.sql.Blob java.sql.CallableStatement.getBlob(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getBlob18440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Blob;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getBlob18440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Blob;
		}
		internal static global::MonoJavaBridge.MethodId _setString18441;
		 void java.sql.CallableStatement.setString(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setString18441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setString18441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setObject18442;
		 void java.sql.CallableStatement.setObject(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setObject18442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setObject18442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setObject18443;
		 void java.sql.CallableStatement.setObject(java.lang.String arg0, java.lang.Object arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setObject18443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setObject18443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setObject18444;
		 void java.sql.CallableStatement.setObject(java.lang.String arg0, java.lang.Object arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setObject18444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setObject18444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _wasNull18445;
		 bool java.sql.CallableStatement.wasNull() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._wasNull18445);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._wasNull18445);
		}
		internal static global::MonoJavaBridge.MethodId _getBigDecimal18446;
		 global::java.math.BigDecimal java.sql.CallableStatement.getBigDecimal(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getBigDecimal18446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getBigDecimal18446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _getBigDecimal18447;
		 global::java.math.BigDecimal java.sql.CallableStatement.getBigDecimal(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getBigDecimal18447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getBigDecimal18447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _getBigDecimal18448;
		 global::java.math.BigDecimal java.sql.CallableStatement.getBigDecimal(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getBigDecimal18448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getBigDecimal18448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterStream18449;
		 global::java.io.Reader java.sql.CallableStatement.getCharacterStream(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getCharacterStream18449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getCharacterStream18449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterStream18450;
		 global::java.io.Reader java.sql.CallableStatement.getCharacterStream(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getCharacterStream18450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getCharacterStream18450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _getClob18451;
		 global::java.sql.Clob java.sql.CallableStatement.getClob(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getClob18451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Clob;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getClob18451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Clob;
		}
		internal static global::MonoJavaBridge.MethodId _getClob18452;
		 global::java.sql.Clob java.sql.CallableStatement.getClob(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getClob18452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Clob;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getClob18452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Clob;
		}
		internal static global::MonoJavaBridge.MethodId _getNString18453;
		 global::java.lang.String java.sql.CallableStatement.getNString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getNString18453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getNString18453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNString18454;
		 global::java.lang.String java.sql.CallableStatement.getNString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getNString18454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getNString18454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNCharacterStream18455;
		 global::java.io.Reader java.sql.CallableStatement.getNCharacterStream(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getNCharacterStream18455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getNCharacterStream18455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _getNCharacterStream18456;
		 global::java.io.Reader java.sql.CallableStatement.getNCharacterStream(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getNCharacterStream18456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getNCharacterStream18456, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _setBytes18457;
		 void java.sql.CallableStatement.setBytes(java.lang.String arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBytes18457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBytes18457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream18458;
		 void java.sql.CallableStatement.setBinaryStream(java.lang.String arg0, java.io.InputStream arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBinaryStream18458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBinaryStream18458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream18459;
		 void java.sql.CallableStatement.setBinaryStream(java.lang.String arg0, java.io.InputStream arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBinaryStream18459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBinaryStream18459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream18460;
		 void java.sql.CallableStatement.setBinaryStream(java.lang.String arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBinaryStream18460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBinaryStream18460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _registerOutParameter18461;
		 void java.sql.CallableStatement.registerOutParameter(int arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._registerOutParameter18461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._registerOutParameter18461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _registerOutParameter18462;
		 void java.sql.CallableStatement.registerOutParameter(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._registerOutParameter18462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._registerOutParameter18462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _registerOutParameter18463;
		 void java.sql.CallableStatement.registerOutParameter(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._registerOutParameter18463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._registerOutParameter18463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _registerOutParameter18464;
		 void java.sql.CallableStatement.registerOutParameter(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._registerOutParameter18464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._registerOutParameter18464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _registerOutParameter18465;
		 void java.sql.CallableStatement.registerOutParameter(java.lang.String arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._registerOutParameter18465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._registerOutParameter18465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _registerOutParameter18466;
		 void java.sql.CallableStatement.registerOutParameter(java.lang.String arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._registerOutParameter18466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._registerOutParameter18466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNull18467;
		 void java.sql.CallableStatement.setNull(java.lang.String arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNull18467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNull18467, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNull18468;
		 void java.sql.CallableStatement.setNull(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNull18468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNull18468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBigDecimal18469;
		 void java.sql.CallableStatement.setBigDecimal(java.lang.String arg0, java.math.BigDecimal arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBigDecimal18469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBigDecimal18469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream18470;
		 void java.sql.CallableStatement.setAsciiStream(java.lang.String arg0, java.io.InputStream arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setAsciiStream18470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setAsciiStream18470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream18471;
		 void java.sql.CallableStatement.setAsciiStream(java.lang.String arg0, java.io.InputStream arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setAsciiStream18471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setAsciiStream18471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream18472;
		 void java.sql.CallableStatement.setAsciiStream(java.lang.String arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setAsciiStream18472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setAsciiStream18472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream18473;
		 void java.sql.CallableStatement.setCharacterStream(java.lang.String arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setCharacterStream18473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setCharacterStream18473, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream18474;
		 void java.sql.CallableStatement.setCharacterStream(java.lang.String arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setCharacterStream18474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setCharacterStream18474, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream18475;
		 void java.sql.CallableStatement.setCharacterStream(java.lang.String arg0, java.io.Reader arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setCharacterStream18475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setCharacterStream18475, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNString18476;
		 void java.sql.CallableStatement.setNString(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNString18476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNString18476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNCharacterStream18477;
		 void java.sql.CallableStatement.setNCharacterStream(java.lang.String arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNCharacterStream18477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNCharacterStream18477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNCharacterStream18478;
		 void java.sql.CallableStatement.setNCharacterStream(java.lang.String arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNCharacterStream18478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNCharacterStream18478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNClob18479;
		 void java.sql.CallableStatement.setNClob(java.lang.String arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNClob18479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNClob18479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNClob18480;
		 void java.sql.CallableStatement.setNClob(java.lang.String arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNClob18480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNClob18480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setClob18481;
		 void java.sql.CallableStatement.setClob(java.lang.String arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setClob18481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setClob18481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setClob18482;
		 void java.sql.CallableStatement.setClob(java.lang.String arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setClob18482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setClob18482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setClob18483;
		 void java.sql.CallableStatement.setClob(java.lang.String arg0, java.sql.Clob arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setClob18483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setClob18483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob18484;
		 void java.sql.CallableStatement.setBlob(java.lang.String arg0, java.io.InputStream arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBlob18484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBlob18484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob18485;
		 void java.sql.CallableStatement.setBlob(java.lang.String arg0, java.sql.Blob arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBlob18485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBlob18485, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob18486;
		 void java.sql.CallableStatement.setBlob(java.lang.String arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBlob18486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBlob18486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBoolean18487;
		 void java.sql.PreparedStatement.setBoolean(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBoolean18487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBoolean18487, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setByte18488;
		 void java.sql.PreparedStatement.setByte(int arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setByte18488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setByte18488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setShort18489;
		 void java.sql.PreparedStatement.setShort(int arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setShort18489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setShort18489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setInt18490;
		 void java.sql.PreparedStatement.setInt(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setInt18490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setInt18490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLong18491;
		 void java.sql.PreparedStatement.setLong(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setLong18491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setLong18491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFloat18492;
		 void java.sql.PreparedStatement.setFloat(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setFloat18492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setFloat18492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDouble18493;
		 void java.sql.PreparedStatement.setDouble(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setDouble18493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setDouble18493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTimestamp18494;
		 void java.sql.PreparedStatement.setTimestamp(int arg0, java.sql.Timestamp arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setTimestamp18494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setTimestamp18494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTimestamp18495;
		 void java.sql.PreparedStatement.setTimestamp(int arg0, java.sql.Timestamp arg1, java.util.Calendar arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setTimestamp18495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setTimestamp18495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setURL18496;
		 void java.sql.PreparedStatement.setURL(int arg0, java.net.URL arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setURL18496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setURL18496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTime18497;
		 void java.sql.PreparedStatement.setTime(int arg0, java.sql.Time arg1, java.util.Calendar arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setTime18497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setTime18497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setTime18498;
		 void java.sql.PreparedStatement.setTime(int arg0, java.sql.Time arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setTime18498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setTime18498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDate18499;
		 void java.sql.PreparedStatement.setDate(int arg0, java.sql.Date arg1, java.util.Calendar arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setDate18499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setDate18499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setDate18500;
		 void java.sql.PreparedStatement.setDate(int arg0, java.sql.Date arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setDate18500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setDate18500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _execute18501;
		 bool java.sql.PreparedStatement.execute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._execute18501);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._execute18501);
		}
		internal static global::MonoJavaBridge.MethodId _addBatch18502;
		 void java.sql.PreparedStatement.addBatch() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._addBatch18502);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._addBatch18502);
		}
		internal static global::MonoJavaBridge.MethodId _setString18503;
		 void java.sql.PreparedStatement.setString(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setString18503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setString18503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setObject18504;
		 void java.sql.PreparedStatement.setObject(int arg0, java.lang.Object arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setObject18504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setObject18504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setObject18505;
		 void java.sql.PreparedStatement.setObject(int arg0, java.lang.Object arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setObject18505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setObject18505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setObject18506;
		 void java.sql.PreparedStatement.setObject(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setObject18506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setObject18506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMetaData18507;
		 global::java.sql.ResultSetMetaData java.sql.PreparedStatement.getMetaData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSetMetaData>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getMetaData18507)) as java.sql.ResultSetMetaData;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSetMetaData>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getMetaData18507)) as java.sql.ResultSetMetaData;
		}
		internal static global::MonoJavaBridge.MethodId _setBytes18508;
		 void java.sql.PreparedStatement.setBytes(int arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBytes18508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBytes18508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream18509;
		 void java.sql.PreparedStatement.setBinaryStream(int arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBinaryStream18509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBinaryStream18509, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream18510;
		 void java.sql.PreparedStatement.setBinaryStream(int arg0, java.io.InputStream arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBinaryStream18510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBinaryStream18510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream18511;
		 void java.sql.PreparedStatement.setBinaryStream(int arg0, java.io.InputStream arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBinaryStream18511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBinaryStream18511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNull18512;
		 void java.sql.PreparedStatement.setNull(int arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNull18512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNull18512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNull18513;
		 void java.sql.PreparedStatement.setNull(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNull18513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNull18513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBigDecimal18514;
		 void java.sql.PreparedStatement.setBigDecimal(int arg0, java.math.BigDecimal arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBigDecimal18514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBigDecimal18514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream18515;
		 void java.sql.PreparedStatement.setAsciiStream(int arg0, java.io.InputStream arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setAsciiStream18515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setAsciiStream18515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream18516;
		 void java.sql.PreparedStatement.setAsciiStream(int arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setAsciiStream18516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setAsciiStream18516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream18517;
		 void java.sql.PreparedStatement.setAsciiStream(int arg0, java.io.InputStream arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setAsciiStream18517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setAsciiStream18517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream18518;
		 void java.sql.PreparedStatement.setCharacterStream(int arg0, java.io.Reader arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setCharacterStream18518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setCharacterStream18518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream18519;
		 void java.sql.PreparedStatement.setCharacterStream(int arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setCharacterStream18519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setCharacterStream18519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream18520;
		 void java.sql.PreparedStatement.setCharacterStream(int arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setCharacterStream18520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setCharacterStream18520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNString18521;
		 void java.sql.PreparedStatement.setNString(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNString18521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNString18521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNCharacterStream18522;
		 void java.sql.PreparedStatement.setNCharacterStream(int arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNCharacterStream18522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNCharacterStream18522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNCharacterStream18523;
		 void java.sql.PreparedStatement.setNCharacterStream(int arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNCharacterStream18523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNCharacterStream18523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNClob18524;
		 void java.sql.PreparedStatement.setNClob(int arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNClob18524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNClob18524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNClob18525;
		 void java.sql.PreparedStatement.setNClob(int arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setNClob18525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setNClob18525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setClob18526;
		 void java.sql.PreparedStatement.setClob(int arg0, java.sql.Clob arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setClob18526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setClob18526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setClob18527;
		 void java.sql.PreparedStatement.setClob(int arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setClob18527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setClob18527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setClob18528;
		 void java.sql.PreparedStatement.setClob(int arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setClob18528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setClob18528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob18529;
		 void java.sql.PreparedStatement.setBlob(int arg0, java.sql.Blob arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBlob18529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBlob18529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob18530;
		 void java.sql.PreparedStatement.setBlob(int arg0, java.io.InputStream arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBlob18530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBlob18530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob18531;
		 void java.sql.PreparedStatement.setBlob(int arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setBlob18531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setBlob18531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _executeQuery18532;
		 global::java.sql.ResultSet java.sql.PreparedStatement.executeQuery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._executeQuery18532)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._executeQuery18532)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate18533;
		 int java.sql.PreparedStatement.executeUpdate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._executeUpdate18533);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._executeUpdate18533);
		}
		internal static global::MonoJavaBridge.MethodId _setUnicodeStream18534;
		 void java.sql.PreparedStatement.setUnicodeStream(int arg0, java.io.InputStream arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setUnicodeStream18534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setUnicodeStream18534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _clearParameters18535;
		 void java.sql.PreparedStatement.clearParameters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._clearParameters18535);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._clearParameters18535);
		}
		internal static global::MonoJavaBridge.MethodId _setRef18536;
		 void java.sql.PreparedStatement.setRef(int arg0, java.sql.Ref arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setRef18536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setRef18536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setArray18537;
		 void java.sql.PreparedStatement.setArray(int arg0, java.sql.Array arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setArray18537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setArray18537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getParameterMetaData18538;
		 global::java.sql.ParameterMetaData java.sql.PreparedStatement.getParameterMetaData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ParameterMetaData>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getParameterMetaData18538)) as java.sql.ParameterMetaData;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ParameterMetaData>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getParameterMetaData18538)) as java.sql.ParameterMetaData;
		}
		internal static global::MonoJavaBridge.MethodId _close18539;
		 void java.sql.Statement.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._close18539);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._close18539);
		}
		internal static global::MonoJavaBridge.MethodId _isClosed18540;
		 bool java.sql.Statement.isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._isClosed18540);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._isClosed18540);
		}
		internal static global::MonoJavaBridge.MethodId _execute18541;
		 bool java.sql.Statement.execute(java.lang.String arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._execute18541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._execute18541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _execute18542;
		 bool java.sql.Statement.execute(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._execute18542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._execute18542, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _execute18543;
		 bool java.sql.Statement.execute(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._execute18543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._execute18543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _execute18544;
		 bool java.sql.Statement.execute(java.lang.String arg0, java.lang.String[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._execute18544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._execute18544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _cancel18545;
		 void java.sql.Statement.cancel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._cancel18545);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._cancel18545);
		}
		internal static global::MonoJavaBridge.MethodId _addBatch18546;
		 void java.sql.Statement.addBatch(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._addBatch18546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._addBatch18546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getConnection18547;
		 global::java.sql.Connection java.sql.Statement.getConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getConnection18547)) as java.sql.Connection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getConnection18547)) as java.sql.Connection;
		}
		internal static global::MonoJavaBridge.MethodId _getResultSet18548;
		 global::java.sql.ResultSet java.sql.Statement.getResultSet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getResultSet18548)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getResultSet18548)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getWarnings18549;
		 global::java.sql.SQLWarning java.sql.Statement.getWarnings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getWarnings18549)) as java.sql.SQLWarning;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getWarnings18549)) as java.sql.SQLWarning;
		}
		internal static global::MonoJavaBridge.MethodId _clearWarnings18550;
		 void java.sql.Statement.clearWarnings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._clearWarnings18550);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._clearWarnings18550);
		}
		internal static global::MonoJavaBridge.MethodId _setFetchDirection18551;
		 void java.sql.Statement.setFetchDirection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setFetchDirection18551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setFetchDirection18551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFetchDirection18552;
		 int java.sql.Statement.getFetchDirection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._getFetchDirection18552);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getFetchDirection18552);
		}
		internal static global::MonoJavaBridge.MethodId _setFetchSize18553;
		 void java.sql.Statement.setFetchSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setFetchSize18553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setFetchSize18553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFetchSize18554;
		 int java.sql.Statement.getFetchSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._getFetchSize18554);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getFetchSize18554);
		}
		internal static global::MonoJavaBridge.MethodId _executeQuery18555;
		 global::java.sql.ResultSet java.sql.Statement.executeQuery(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._executeQuery18555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._executeQuery18555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate18556;
		 int java.sql.Statement.executeUpdate(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._executeUpdate18556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._executeUpdate18556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate18557;
		 int java.sql.Statement.executeUpdate(java.lang.String arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._executeUpdate18557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._executeUpdate18557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate18558;
		 int java.sql.Statement.executeUpdate(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._executeUpdate18558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._executeUpdate18558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate18559;
		 int java.sql.Statement.executeUpdate(java.lang.String arg0, java.lang.String[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._executeUpdate18559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._executeUpdate18559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxFieldSize18560;
		 int java.sql.Statement.getMaxFieldSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._getMaxFieldSize18560);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getMaxFieldSize18560);
		}
		internal static global::MonoJavaBridge.MethodId _setMaxFieldSize18561;
		 void java.sql.Statement.setMaxFieldSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setMaxFieldSize18561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setMaxFieldSize18561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxRows18562;
		 int java.sql.Statement.getMaxRows() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._getMaxRows18562);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getMaxRows18562);
		}
		internal static global::MonoJavaBridge.MethodId _setMaxRows18563;
		 void java.sql.Statement.setMaxRows(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setMaxRows18563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setMaxRows18563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEscapeProcessing18564;
		 void java.sql.Statement.setEscapeProcessing(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setEscapeProcessing18564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setEscapeProcessing18564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getQueryTimeout18565;
		 int java.sql.Statement.getQueryTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._getQueryTimeout18565);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getQueryTimeout18565);
		}
		internal static global::MonoJavaBridge.MethodId _setQueryTimeout18566;
		 void java.sql.Statement.setQueryTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setQueryTimeout18566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setQueryTimeout18566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCursorName18567;
		 void java.sql.Statement.setCursorName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setCursorName18567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setCursorName18567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUpdateCount18568;
		 int java.sql.Statement.getUpdateCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._getUpdateCount18568);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getUpdateCount18568);
		}
		internal static global::MonoJavaBridge.MethodId _getMoreResults18569;
		 bool java.sql.Statement.getMoreResults() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._getMoreResults18569);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getMoreResults18569);
		}
		internal static global::MonoJavaBridge.MethodId _getMoreResults18570;
		 bool java.sql.Statement.getMoreResults(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._getMoreResults18570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getMoreResults18570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getResultSetConcurrency18571;
		 int java.sql.Statement.getResultSetConcurrency() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._getResultSetConcurrency18571);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getResultSetConcurrency18571);
		}
		internal static global::MonoJavaBridge.MethodId _getResultSetType18572;
		 int java.sql.Statement.getResultSetType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._getResultSetType18572);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getResultSetType18572);
		}
		internal static global::MonoJavaBridge.MethodId _clearBatch18573;
		 void java.sql.Statement.clearBatch() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._clearBatch18573);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._clearBatch18573);
		}
		internal static global::MonoJavaBridge.MethodId _executeBatch18574;
		 int[] java.sql.Statement.executeBatch() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._executeBatch18574)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._executeBatch18574)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _getGeneratedKeys18575;
		 global::java.sql.ResultSet java.sql.Statement.getGeneratedKeys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_._getGeneratedKeys18575)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getGeneratedKeys18575)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getResultSetHoldability18576;
		 int java.sql.Statement.getResultSetHoldability() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.CallableStatement_._getResultSetHoldability18576);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._getResultSetHoldability18576);
		}
		internal static global::MonoJavaBridge.MethodId _setPoolable18577;
		 void java.sql.Statement.setPoolable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_._setPoolable18577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._setPoolable18577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPoolable18578;
		 bool java.sql.Statement.isPoolable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_._isPoolable18578);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.CallableStatement_.staticClass, global::java.sql.CallableStatement_._isPoolable18578);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.CallableStatement_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/CallableStatement"));
			global::java.sql.CallableStatement_._getObject18385 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getObject", "(ILjava/util/Map;)Ljava/lang/Object;");
			global::java.sql.CallableStatement_._getObject18386 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getObject", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::java.sql.CallableStatement_._getObject18387 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getObject", "(I)Ljava/lang/Object;");
			global::java.sql.CallableStatement_._getObject18388 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getObject", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/Object;");
			global::java.sql.CallableStatement_._getBoolean18389 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getBoolean", "(I)Z");
			global::java.sql.CallableStatement_._getBoolean18390 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getBoolean", "(Ljava/lang/String;)Z");
			global::java.sql.CallableStatement_._getByte18391 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getByte", "(I)B");
			global::java.sql.CallableStatement_._getByte18392 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getByte", "(Ljava/lang/String;)B");
			global::java.sql.CallableStatement_._getShort18393 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getShort", "(I)S");
			global::java.sql.CallableStatement_._getShort18394 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getShort", "(Ljava/lang/String;)S");
			global::java.sql.CallableStatement_._getInt18395 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getInt", "(Ljava/lang/String;)I");
			global::java.sql.CallableStatement_._getInt18396 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getInt", "(I)I");
			global::java.sql.CallableStatement_._getLong18397 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getLong", "(I)J");
			global::java.sql.CallableStatement_._getLong18398 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getLong", "(Ljava/lang/String;)J");
			global::java.sql.CallableStatement_._getFloat18399 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getFloat", "(Ljava/lang/String;)F");
			global::java.sql.CallableStatement_._getFloat18400 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getFloat", "(I)F");
			global::java.sql.CallableStatement_._getDouble18401 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getDouble", "(Ljava/lang/String;)D");
			global::java.sql.CallableStatement_._getDouble18402 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getDouble", "(I)D");
			global::java.sql.CallableStatement_._getBytes18403 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getBytes", "(I)[B");
			global::java.sql.CallableStatement_._getBytes18404 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getBytes", "(Ljava/lang/String;)[B");
			global::java.sql.CallableStatement_._getArray18405 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getArray", "(I)Ljava/sql/Array;");
			global::java.sql.CallableStatement_._getArray18406 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getArray", "(Ljava/lang/String;)Ljava/sql/Array;");
			global::java.sql.CallableStatement_._getURL18407 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getURL", "(I)Ljava/net/URL;");
			global::java.sql.CallableStatement_._getURL18408 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getURL", "(Ljava/lang/String;)Ljava/net/URL;");
			global::java.sql.CallableStatement_._setBoolean18409 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBoolean", "(Ljava/lang/String;Z)V");
			global::java.sql.CallableStatement_._setByte18410 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setByte", "(Ljava/lang/String;B)V");
			global::java.sql.CallableStatement_._setShort18411 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setShort", "(Ljava/lang/String;S)V");
			global::java.sql.CallableStatement_._setInt18412 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setInt", "(Ljava/lang/String;I)V");
			global::java.sql.CallableStatement_._setLong18413 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setLong", "(Ljava/lang/String;J)V");
			global::java.sql.CallableStatement_._setFloat18414 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setFloat", "(Ljava/lang/String;F)V");
			global::java.sql.CallableStatement_._setDouble18415 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setDouble", "(Ljava/lang/String;D)V");
			global::java.sql.CallableStatement_._setTimestamp18416 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;Ljava/util/Calendar;)V");
			global::java.sql.CallableStatement_._setTimestamp18417 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;)V");
			global::java.sql.CallableStatement_._getRef18418 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getRef", "(I)Ljava/sql/Ref;");
			global::java.sql.CallableStatement_._getRef18419 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getRef", "(Ljava/lang/String;)Ljava/sql/Ref;");
			global::java.sql.CallableStatement_._getString18420 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getString", "(I)Ljava/lang/String;");
			global::java.sql.CallableStatement_._getString18421 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.sql.CallableStatement_._setURL18422 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setURL", "(Ljava/lang/String;Ljava/net/URL;)V");
			global::java.sql.CallableStatement_._setTime18423 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setTime", "(Ljava/lang/String;Ljava/sql/Time;)V");
			global::java.sql.CallableStatement_._setTime18424 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setTime", "(Ljava/lang/String;Ljava/sql/Time;Ljava/util/Calendar;)V");
			global::java.sql.CallableStatement_._getTime18425 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getTime", "(I)Ljava/sql/Time;");
			global::java.sql.CallableStatement_._getTime18426 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getTime", "(Ljava/lang/String;)Ljava/sql/Time;");
			global::java.sql.CallableStatement_._getTime18427 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getTime", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Time;");
			global::java.sql.CallableStatement_._getTime18428 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getTime", "(ILjava/util/Calendar;)Ljava/sql/Time;");
			global::java.sql.CallableStatement_._getDate18429 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getDate", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Date;");
			global::java.sql.CallableStatement_._getDate18430 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getDate", "(ILjava/util/Calendar;)Ljava/sql/Date;");
			global::java.sql.CallableStatement_._getDate18431 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getDate", "(Ljava/lang/String;)Ljava/sql/Date;");
			global::java.sql.CallableStatement_._getDate18432 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getDate", "(I)Ljava/sql/Date;");
			global::java.sql.CallableStatement_._getTimestamp18433 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getTimestamp", "(I)Ljava/sql/Timestamp;");
			global::java.sql.CallableStatement_._getTimestamp18434 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getTimestamp", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Timestamp;");
			global::java.sql.CallableStatement_._getTimestamp18435 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getTimestamp", "(Ljava/lang/String;)Ljava/sql/Timestamp;");
			global::java.sql.CallableStatement_._getTimestamp18436 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getTimestamp", "(ILjava/util/Calendar;)Ljava/sql/Timestamp;");
			global::java.sql.CallableStatement_._setDate18437 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setDate", "(Ljava/lang/String;Ljava/sql/Date;)V");
			global::java.sql.CallableStatement_._setDate18438 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setDate", "(Ljava/lang/String;Ljava/sql/Date;Ljava/util/Calendar;)V");
			global::java.sql.CallableStatement_._getBlob18439 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getBlob", "(I)Ljava/sql/Blob;");
			global::java.sql.CallableStatement_._getBlob18440 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getBlob", "(Ljava/lang/String;)Ljava/sql/Blob;");
			global::java.sql.CallableStatement_._setString18441 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setString", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.sql.CallableStatement_._setObject18442 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setObject", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::java.sql.CallableStatement_._setObject18443 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setObject", "(Ljava/lang/String;Ljava/lang/Object;I)V");
			global::java.sql.CallableStatement_._setObject18444 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setObject", "(Ljava/lang/String;Ljava/lang/Object;II)V");
			global::java.sql.CallableStatement_._wasNull18445 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "wasNull", "()Z");
			global::java.sql.CallableStatement_._getBigDecimal18446 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getBigDecimal", "(II)Ljava/math/BigDecimal;");
			global::java.sql.CallableStatement_._getBigDecimal18447 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getBigDecimal", "(Ljava/lang/String;)Ljava/math/BigDecimal;");
			global::java.sql.CallableStatement_._getBigDecimal18448 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getBigDecimal", "(I)Ljava/math/BigDecimal;");
			global::java.sql.CallableStatement_._getCharacterStream18449 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getCharacterStream", "(I)Ljava/io/Reader;");
			global::java.sql.CallableStatement_._getCharacterStream18450 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;");
			global::java.sql.CallableStatement_._getClob18451 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getClob", "(I)Ljava/sql/Clob;");
			global::java.sql.CallableStatement_._getClob18452 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getClob", "(Ljava/lang/String;)Ljava/sql/Clob;");
			global::java.sql.CallableStatement_._getNString18453 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getNString", "(I)Ljava/lang/String;");
			global::java.sql.CallableStatement_._getNString18454 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getNString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.sql.CallableStatement_._getNCharacterStream18455 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getNCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;");
			global::java.sql.CallableStatement_._getNCharacterStream18456 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getNCharacterStream", "(I)Ljava/io/Reader;");
			global::java.sql.CallableStatement_._setBytes18457 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBytes", "(Ljava/lang/String;[B)V");
			global::java.sql.CallableStatement_._setBinaryStream18458 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V");
			global::java.sql.CallableStatement_._setBinaryStream18459 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;J)V");
			global::java.sql.CallableStatement_._setBinaryStream18460 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;)V");
			global::java.sql.CallableStatement_._registerOutParameter18461 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "registerOutParameter", "(IILjava/lang/String;)V");
			global::java.sql.CallableStatement_._registerOutParameter18462 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "registerOutParameter", "(III)V");
			global::java.sql.CallableStatement_._registerOutParameter18463 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "registerOutParameter", "(II)V");
			global::java.sql.CallableStatement_._registerOutParameter18464 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "registerOutParameter", "(Ljava/lang/String;I)V");
			global::java.sql.CallableStatement_._registerOutParameter18465 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "registerOutParameter", "(Ljava/lang/String;II)V");
			global::java.sql.CallableStatement_._registerOutParameter18466 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "registerOutParameter", "(Ljava/lang/String;ILjava/lang/String;)V");
			global::java.sql.CallableStatement_._setNull18467 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNull", "(Ljava/lang/String;ILjava/lang/String;)V");
			global::java.sql.CallableStatement_._setNull18468 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNull", "(Ljava/lang/String;I)V");
			global::java.sql.CallableStatement_._setBigDecimal18469 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBigDecimal", "(Ljava/lang/String;Ljava/math/BigDecimal;)V");
			global::java.sql.CallableStatement_._setAsciiStream18470 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V");
			global::java.sql.CallableStatement_._setAsciiStream18471 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;J)V");
			global::java.sql.CallableStatement_._setAsciiStream18472 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;)V");
			global::java.sql.CallableStatement_._setCharacterStream18473 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::java.sql.CallableStatement_._setCharacterStream18474 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V");
			global::java.sql.CallableStatement_._setCharacterStream18475 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;I)V");
			global::java.sql.CallableStatement_._setNString18476 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNString", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::java.sql.CallableStatement_._setNCharacterStream18477 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V");
			global::java.sql.CallableStatement_._setNCharacterStream18478 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::java.sql.CallableStatement_._setNClob18479 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNClob", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::java.sql.CallableStatement_._setNClob18480 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNClob", "(Ljava/lang/String;Ljava/io/Reader;)V");
			global::java.sql.CallableStatement_._setClob18481 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setClob", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::java.sql.CallableStatement_._setClob18482 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setClob", "(Ljava/lang/String;Ljava/io/Reader;)V");
			global::java.sql.CallableStatement_._setClob18483 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setClob", "(Ljava/lang/String;Ljava/sql/Clob;)V");
			global::java.sql.CallableStatement_._setBlob18484 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBlob", "(Ljava/lang/String;Ljava/io/InputStream;J)V");
			global::java.sql.CallableStatement_._setBlob18485 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBlob", "(Ljava/lang/String;Ljava/sql/Blob;)V");
			global::java.sql.CallableStatement_._setBlob18486 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBlob", "(Ljava/lang/String;Ljava/io/InputStream;)V");
			global::java.sql.CallableStatement_._setBoolean18487 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBoolean", "(IZ)V");
			global::java.sql.CallableStatement_._setByte18488 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setByte", "(IB)V");
			global::java.sql.CallableStatement_._setShort18489 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setShort", "(IS)V");
			global::java.sql.CallableStatement_._setInt18490 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setInt", "(II)V");
			global::java.sql.CallableStatement_._setLong18491 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setLong", "(IJ)V");
			global::java.sql.CallableStatement_._setFloat18492 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setFloat", "(IF)V");
			global::java.sql.CallableStatement_._setDouble18493 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setDouble", "(ID)V");
			global::java.sql.CallableStatement_._setTimestamp18494 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setTimestamp", "(ILjava/sql/Timestamp;)V");
			global::java.sql.CallableStatement_._setTimestamp18495 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setTimestamp", "(ILjava/sql/Timestamp;Ljava/util/Calendar;)V");
			global::java.sql.CallableStatement_._setURL18496 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setURL", "(ILjava/net/URL;)V");
			global::java.sql.CallableStatement_._setTime18497 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setTime", "(ILjava/sql/Time;Ljava/util/Calendar;)V");
			global::java.sql.CallableStatement_._setTime18498 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setTime", "(ILjava/sql/Time;)V");
			global::java.sql.CallableStatement_._setDate18499 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setDate", "(ILjava/sql/Date;Ljava/util/Calendar;)V");
			global::java.sql.CallableStatement_._setDate18500 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setDate", "(ILjava/sql/Date;)V");
			global::java.sql.CallableStatement_._execute18501 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "execute", "()Z");
			global::java.sql.CallableStatement_._addBatch18502 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "addBatch", "()V");
			global::java.sql.CallableStatement_._setString18503 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setString", "(ILjava/lang/String;)V");
			global::java.sql.CallableStatement_._setObject18504 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setObject", "(ILjava/lang/Object;I)V");
			global::java.sql.CallableStatement_._setObject18505 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setObject", "(ILjava/lang/Object;II)V");
			global::java.sql.CallableStatement_._setObject18506 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setObject", "(ILjava/lang/Object;)V");
			global::java.sql.CallableStatement_._getMetaData18507 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getMetaData", "()Ljava/sql/ResultSetMetaData;");
			global::java.sql.CallableStatement_._setBytes18508 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBytes", "(I[B)V");
			global::java.sql.CallableStatement_._setBinaryStream18509 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBinaryStream", "(ILjava/io/InputStream;)V");
			global::java.sql.CallableStatement_._setBinaryStream18510 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBinaryStream", "(ILjava/io/InputStream;I)V");
			global::java.sql.CallableStatement_._setBinaryStream18511 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBinaryStream", "(ILjava/io/InputStream;J)V");
			global::java.sql.CallableStatement_._setNull18512 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNull", "(IILjava/lang/String;)V");
			global::java.sql.CallableStatement_._setNull18513 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNull", "(II)V");
			global::java.sql.CallableStatement_._setBigDecimal18514 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBigDecimal", "(ILjava/math/BigDecimal;)V");
			global::java.sql.CallableStatement_._setAsciiStream18515 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setAsciiStream", "(ILjava/io/InputStream;I)V");
			global::java.sql.CallableStatement_._setAsciiStream18516 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setAsciiStream", "(ILjava/io/InputStream;)V");
			global::java.sql.CallableStatement_._setAsciiStream18517 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setAsciiStream", "(ILjava/io/InputStream;J)V");
			global::java.sql.CallableStatement_._setCharacterStream18518 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setCharacterStream", "(ILjava/io/Reader;I)V");
			global::java.sql.CallableStatement_._setCharacterStream18519 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setCharacterStream", "(ILjava/io/Reader;J)V");
			global::java.sql.CallableStatement_._setCharacterStream18520 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setCharacterStream", "(ILjava/io/Reader;)V");
			global::java.sql.CallableStatement_._setNString18521 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNString", "(ILjava/lang/String;)V");
			global::java.sql.CallableStatement_._setNCharacterStream18522 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNCharacterStream", "(ILjava/io/Reader;J)V");
			global::java.sql.CallableStatement_._setNCharacterStream18523 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNCharacterStream", "(ILjava/io/Reader;)V");
			global::java.sql.CallableStatement_._setNClob18524 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNClob", "(ILjava/io/Reader;)V");
			global::java.sql.CallableStatement_._setNClob18525 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setNClob", "(ILjava/io/Reader;J)V");
			global::java.sql.CallableStatement_._setClob18526 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setClob", "(ILjava/sql/Clob;)V");
			global::java.sql.CallableStatement_._setClob18527 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setClob", "(ILjava/io/Reader;J)V");
			global::java.sql.CallableStatement_._setClob18528 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setClob", "(ILjava/io/Reader;)V");
			global::java.sql.CallableStatement_._setBlob18529 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBlob", "(ILjava/sql/Blob;)V");
			global::java.sql.CallableStatement_._setBlob18530 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBlob", "(ILjava/io/InputStream;J)V");
			global::java.sql.CallableStatement_._setBlob18531 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setBlob", "(ILjava/io/InputStream;)V");
			global::java.sql.CallableStatement_._executeQuery18532 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "executeQuery", "()Ljava/sql/ResultSet;");
			global::java.sql.CallableStatement_._executeUpdate18533 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "executeUpdate", "()I");
			global::java.sql.CallableStatement_._setUnicodeStream18534 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setUnicodeStream", "(ILjava/io/InputStream;I)V");
			global::java.sql.CallableStatement_._clearParameters18535 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "clearParameters", "()V");
			global::java.sql.CallableStatement_._setRef18536 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setRef", "(ILjava/sql/Ref;)V");
			global::java.sql.CallableStatement_._setArray18537 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setArray", "(ILjava/sql/Array;)V");
			global::java.sql.CallableStatement_._getParameterMetaData18538 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getParameterMetaData", "()Ljava/sql/ParameterMetaData;");
			global::java.sql.CallableStatement_._close18539 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "close", "()V");
			global::java.sql.CallableStatement_._isClosed18540 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "isClosed", "()Z");
			global::java.sql.CallableStatement_._execute18541 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "execute", "(Ljava/lang/String;[I)Z");
			global::java.sql.CallableStatement_._execute18542 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "execute", "(Ljava/lang/String;I)Z");
			global::java.sql.CallableStatement_._execute18543 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "execute", "(Ljava/lang/String;)Z");
			global::java.sql.CallableStatement_._execute18544 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "execute", "(Ljava/lang/String;[Ljava/lang/String;)Z");
			global::java.sql.CallableStatement_._cancel18545 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "cancel", "()V");
			global::java.sql.CallableStatement_._addBatch18546 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "addBatch", "(Ljava/lang/String;)V");
			global::java.sql.CallableStatement_._getConnection18547 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getConnection", "()Ljava/sql/Connection;");
			global::java.sql.CallableStatement_._getResultSet18548 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getResultSet", "()Ljava/sql/ResultSet;");
			global::java.sql.CallableStatement_._getWarnings18549 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getWarnings", "()Ljava/sql/SQLWarning;");
			global::java.sql.CallableStatement_._clearWarnings18550 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "clearWarnings", "()V");
			global::java.sql.CallableStatement_._setFetchDirection18551 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setFetchDirection", "(I)V");
			global::java.sql.CallableStatement_._getFetchDirection18552 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getFetchDirection", "()I");
			global::java.sql.CallableStatement_._setFetchSize18553 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setFetchSize", "(I)V");
			global::java.sql.CallableStatement_._getFetchSize18554 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getFetchSize", "()I");
			global::java.sql.CallableStatement_._executeQuery18555 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "executeQuery", "(Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.CallableStatement_._executeUpdate18556 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "executeUpdate", "(Ljava/lang/String;I)I");
			global::java.sql.CallableStatement_._executeUpdate18557 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "executeUpdate", "(Ljava/lang/String;[I)I");
			global::java.sql.CallableStatement_._executeUpdate18558 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "executeUpdate", "(Ljava/lang/String;)I");
			global::java.sql.CallableStatement_._executeUpdate18559 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "executeUpdate", "(Ljava/lang/String;[Ljava/lang/String;)I");
			global::java.sql.CallableStatement_._getMaxFieldSize18560 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getMaxFieldSize", "()I");
			global::java.sql.CallableStatement_._setMaxFieldSize18561 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setMaxFieldSize", "(I)V");
			global::java.sql.CallableStatement_._getMaxRows18562 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getMaxRows", "()I");
			global::java.sql.CallableStatement_._setMaxRows18563 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setMaxRows", "(I)V");
			global::java.sql.CallableStatement_._setEscapeProcessing18564 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setEscapeProcessing", "(Z)V");
			global::java.sql.CallableStatement_._getQueryTimeout18565 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getQueryTimeout", "()I");
			global::java.sql.CallableStatement_._setQueryTimeout18566 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setQueryTimeout", "(I)V");
			global::java.sql.CallableStatement_._setCursorName18567 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setCursorName", "(Ljava/lang/String;)V");
			global::java.sql.CallableStatement_._getUpdateCount18568 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getUpdateCount", "()I");
			global::java.sql.CallableStatement_._getMoreResults18569 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getMoreResults", "()Z");
			global::java.sql.CallableStatement_._getMoreResults18570 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getMoreResults", "(I)Z");
			global::java.sql.CallableStatement_._getResultSetConcurrency18571 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getResultSetConcurrency", "()I");
			global::java.sql.CallableStatement_._getResultSetType18572 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getResultSetType", "()I");
			global::java.sql.CallableStatement_._clearBatch18573 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "clearBatch", "()V");
			global::java.sql.CallableStatement_._executeBatch18574 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "executeBatch", "()[I");
			global::java.sql.CallableStatement_._getGeneratedKeys18575 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getGeneratedKeys", "()Ljava/sql/ResultSet;");
			global::java.sql.CallableStatement_._getResultSetHoldability18576 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "getResultSetHoldability", "()I");
			global::java.sql.CallableStatement_._setPoolable18577 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "setPoolable", "(Z)V");
			global::java.sql.CallableStatement_._isPoolable18578 = @__env.GetMethodIDNoThrow(global::java.sql.CallableStatement_.staticClass, "isPoolable", "()Z");
		}
	}
}
